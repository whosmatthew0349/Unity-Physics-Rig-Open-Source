using UnityEngine;

namespace PhysicsVRrigRC
{
    public class PhysicsRig : MonoBehaviour
    {
        public Transform PlayerHead;
        public Transform leftController;
        public Transform rightController;

        public ConfigurableJoint headJoint;
        public ConfigurableJoint rightHandJoint;
        public ConfigurableJoint leftHandJoint;

        void FixedUpdate()
        {
            leftHandJoint.targetPosition = leftController.localPosition;
            leftHandJoint.targetRotation = leftController.localRotation;

            rightHandJoint.targetPosition = rightController.localPosition;
            rightHandJoint.targetRotation = rightController.localRotation;

            headJoint.targetPosition = PlayerHead.localPosition;
        }
    }
}
