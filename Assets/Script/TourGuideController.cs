using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Convai.Scripts.Runtime.Features;


public class TourGuideController : MonoBehaviour
{

    private ConvaiActionsHandler _convaiActionsHandler;

    private void Awake()
    {
        _convaiActionsHandler = GetComponent<ConvaiActionsHandler>();
    }

    public void MoveTo(GameObject obj)
    {
        StartCoroutine(_convaiActionsHandler.MoveTo(obj));
    }
}
