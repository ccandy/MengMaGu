using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.Events;

public class MMGEventSystem : MGGSingleton<MMGEventSystem>
{
    private Dictionary<string, UnityEvent> _eventsDic;

    private void Start()
    {
        if (_eventsDic == null)
        {
            _eventsDic = new Dictionary<string, UnityEvent>();
        }
    }

    public void StartListening(string eventName, UnityAction listener)
    {
        if (listener == null)
        {
            Debug.Log("listener cannot be null");
            return;
        }

        UnityEvent thisEvent = null;
        if (_eventsDic.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.AddListener(listener);
        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            _eventsDic.Add(eventName, thisEvent);
        }
    }

    public void StopListening(string eventName, UnityAction listener)
    {
        if (listener == null)
        {
            Debug.Log("listener cannot be null");
            return;
        }
        UnityEvent thisEvent = null;
        if (_eventsDic.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.RemoveListener(listener);
        }
    }

    public void TriggerEvent(string eventName)
    {
        UnityEvent thisEvent = null;
        if (_eventsDic.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.Invoke();
        }
        else
        {
            Debug.Log("No such event");
        }
    }
}
