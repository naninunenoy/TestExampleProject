using System.Linq;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace WithTestProject
{
    public class SampleScene : MonoBehaviour
    {
        [SerializeField] Toggle[] bitToggles = default;
        [SerializeField] Text text = default;

        readonly BitsToString _bitsToString = new();

        void Start()
        {
            bitToggles.Select(x => x.OnValueChangedAsObservable())
                .Merge()
                .Subscribe(_ => { SetBitText(); })
                .AddTo(this);
        }

        void SetBitText()
        {
            text.text = _bitsToString.ToString(
                bitToggles[3].isOn, bitToggles[2].isOn, bitToggles[1].isOn, bitToggles[0].isOn);
        }
    }
}
