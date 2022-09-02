using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterestWithEvents : MonoBehaviour //OBSERVABLE
{
    //Static so you don't need a reference to the correct point of interest
    public static event Action<PointOfInterestWithEvents> OnPointOfInterestEntered;
    //Another good way of doing it would be:
    //public static event Action<string> OnPointOfInterestEntered;
    //This way you can just pass the poi name instead of this entire object

    [SerializeField]
    private string _poiName;

    public string PoiName
    {
        get
        {
            return _poiName;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(OnPointOfInterestEntered != null)
        {
            OnPointOfInterestEntered(this);
            //OnPointOfInterestEntered(this._poiName);
        }
    }
}
