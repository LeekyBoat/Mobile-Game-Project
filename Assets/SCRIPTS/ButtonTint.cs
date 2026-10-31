using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ButtonTint : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private Color tintColor;
    [Range(0f, 1f)]
    [SerializeField] private float tintStrength;

    private List<Material> materials = new List<Material>();
    private List<Color> originalColors = new List<Color>();

    void Awake()
    {
        Renderer[] rend = GetComponentsInChildren<Renderer>();
        for (int i = 0; i < rend.Length; i++)
        {
            Material[] mats = rend[i].materials;
            for (int j = 0; j < mats.Length; j++)
            {
                materials.Add(mats[j]);
                originalColors.Add(mats[j].color);
            }
        }
    }
    private void ApplyTint(float amount)
    {
        for (int i = 0; i < materials.Count; i++)
        {
            materials[i].color = Color.Lerp(originalColors[i], tintColor, amount);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ApplyTint(tintStrength);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        ApplyTint(0);
    }
    public void OnPointerClick(PointerEventData eventData)
    {

    }
}
