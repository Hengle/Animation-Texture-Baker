using UnityEngine;

namespace AnimationBaker.StateMachine.XNode
{
    [System.Serializable]
    public class NodeGraphVariable : ScriptableObject
    {
        public VariableType VariableType = VariableType.Boolean;
        public float DefaultFloatVal;
        public int DefaultIntVal;
        public bool DefaultBoolVal;
        public bool RuntimeTriggerVal { get; set; }
        public float RuntimeFloatVal { get; set; }
        public int RuntimeIntVal { get; set; }
        public bool RuntimeBoolVal { get; set; }
    }

    [System.Serializable]
    public enum VariableType
    {
        Integer,
        Float,
        Boolean,
        Trigger
    }
}
