using UnityEngine;

namespace WithTestProject
{
    [CreateAssetMenu(fileName = "ColorConfig", menuName = "ColorConfig", order = 0)]
    public class ColorConfig : ScriptableObject
    {
        [SerializeField] Color onColor;
        [SerializeField] Color offColor;
        public Color OnColor => onColor;
        public Color OffColor => offColor;
    }
}
