using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observable : MonoBehaviour
{
    private List<Observer> _observers = new List<Observer>();

    public void RegisterObserver(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Notify(object value, NotificationType nType)
    {
        foreach (var observer in _observers)
        {
            observer.OnNotify(value, nType);
        }
    }
}
