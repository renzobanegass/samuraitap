using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelDeactivator : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject panelRight;
    [SerializeField] private GameObject panelLeft;
    [SerializeField] private WinnerPanel winnerPanel;

    void Awake()
    {
        winnerPanel.Name = "";
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        DeactivatePanel(eventData.pointerCurrentRaycast.gameObject);
    }

    private void DeactivatePanel(GameObject panel)
    {
        if (panel.tag == "LeftPanel")
        {
            panelRight.SetActive(false);
            winnerPanel.Name = panel.tag;
        }
        else if (panel.tag == "RightPanel")
        {
            panelLeft.SetActive(false);
            winnerPanel.Name = panel.tag;
        }
    }
    
}
