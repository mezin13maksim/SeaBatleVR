namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;

    public class ControlReactor : MonoBehaviour
    {
        
        public ShipFloatController shipFloatController;
        private VRTK_Control_UnityEvents controlEvents;
        private float startLeaverRotation = 0;
        public float angleK = 0.01f;

        private void Start()
        {
            controlEvents = GetComponent<VRTK_Control_UnityEvents>();
            if (controlEvents == null)
            {
                controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
            }
            startLeaverRotation = this.transform.localRotation.eulerAngles.z;
            controlEvents.OnValueChanged.AddListener(HandleChange);
        }

        private void HandleChange(object sender, Control3DEventArgs e)
        {
            
            float t = this.transform.localRotation.eulerAngles.z;
            if (t > 110) { shipFloatController.leaverValue = 1; }
            else if (t < 70) { shipFloatController.leaverValue = -1; }
            else shipFloatController.leaverValue = 0;


            
        }
    }
}