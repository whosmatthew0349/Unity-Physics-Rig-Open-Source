using UnityEngine;
using easyInputs;
using Photon.Pun;

namespace PhysicsVRrigRC
{
    public class GrabPhysics : MonoBehaviour
    {
        [Header("Grab Settings")]
        public float radius = 0.1f; // you can edit this if youd like, i use 0.25 for Chump :)
        public LayerMask grabLayer;

        [Header("Auto Detect")]
        public bool isLeftHand = false;

        private EasyHand grabHand;

        private FixedJoint fixedJoint;
        private bool isGrabbing = false;
        private Rigidbody grabbedRigidbody;
        private PhotonView grabbedPhotonView;

        private void Start()
        {
            grabHand = isLeftHand ? EasyHand.LeftHand : EasyHand.RightHand;
        }

        private void FixedUpdate()
        {
            bool isGrabButtonPressed = EasyInputs.GetGripButtonFloat(grabHand) > 0.1f;

            if (isGrabButtonPressed && !isGrabbing)
            {
                Collider[] nearbyColliders = Physics.OverlapSphere(
                    transform.position,
                    radius,
                    grabLayer,
                    QueryTriggerInteraction.Ignore
                );

                if (nearbyColliders.Length > 0)
                {
                    Collider closest = nearbyColliders[0];
                    float closestDist = Vector3.Distance(transform.position, closest.ClosestPoint(transform.position));

                    for (int i = 1; i < nearbyColliders.Length; i++)
                    {
                        float dist = Vector3.Distance(transform.position, nearbyColliders[i].ClosestPoint(transform.position));
                        if (dist < closestDist)
                        {
                            closestDist = dist;
                            closest = nearbyColliders[i];
                        }
                    }

                    grabbedRigidbody = closest.attachedRigidbody;

                    if (grabbedRigidbody != null)
                    {
                        PhotonView pv = grabbedRigidbody.GetComponent<PhotonView>();
                        if (pv != null && !pv.IsMine)
                        {
                            pv.RequestOwnership();
                        }
                        grabbedPhotonView = pv;
                    }

                    fixedJoint = gameObject.AddComponent<FixedJoint>();
                    fixedJoint.autoConfigureConnectedAnchor = false;
                    fixedJoint.connectedBody = grabbedRigidbody;

                    if (grabbedRigidbody != null)
                    {
                        fixedJoint.connectedAnchor = grabbedRigidbody.transform.InverseTransformPoint(transform.position);

                        grabbedRigidbody.transform.SetParent(transform);
                    }
                    else
                    {
                        fixedJoint.connectedAnchor = transform.position;
                    }

                    isGrabbing = true;
                }
            }

            if (!isGrabButtonPressed && isGrabbing)
            {
                isGrabbing = false;

                if (fixedJoint != null)
                {
                    Destroy(fixedJoint);
                    fixedJoint = null;
                }

                if (grabbedRigidbody != null)
                {
                    grabbedRigidbody.transform.SetParent(null);
                }

                grabbedRigidbody = null;
                grabbedPhotonView = null;
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }
}
