using UnityEngine;
using UnityEngine.Rendering;

public class ColorSpaceSwitcher : MonoBehaviour
{
    public void SwitchColorSpaceToLinear()
    {
        QualitySettings.activeColorSpace = ColorSpace.Linear;
    }

    public void SwitchColorSpaceToGamma()
    {
        QualitySettings.activeColorSpace = ColorSpace.Gamma;
    }
}
