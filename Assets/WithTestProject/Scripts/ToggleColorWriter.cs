using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace WithTestProject
{
    public class ToggleColorWriter : MonoBehaviour
    {
        [SerializeField] ColorConfig colorConfig = default;

        void Start()
        {
            var toggle = GetComponent<Toggle>();
            if (toggle == null) return;
            toggle.OnValueChangedAsObservable()
                .Subscribe(isOn =>
                {
                    toggle.targetGraphic.color = isOn ? colorConfig.OnColor : colorConfig.OffColor;
                })
                .AddTo(this);
        }
    }
}
