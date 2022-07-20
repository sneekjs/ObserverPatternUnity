using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterest : Observable
{
    [SerializeField]
    private string _poiName;

    private void OnTriggerEnter(Collider other)
    {
        Notify(_poiName, NotificationType.AchievementUnlocked);
    }
}
