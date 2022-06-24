#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace ThirdPersonSystem
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(AnimatorManager))]
    public class AnimatorManagerInspector : BaseInspector
    {
        protected override void FormatLabel()
        {
            label = "Animator Manager";

        }
    }
}
#endif