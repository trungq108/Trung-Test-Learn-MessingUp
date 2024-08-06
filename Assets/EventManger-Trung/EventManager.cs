using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }
    private Dictionary<Type, List<Action<object>>> eventHandlers;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        eventHandlers = new Dictionary<Type, List<Action<object>>>();
    }

    public void AddListener<T>(Action<T> handler)
    {
        Type eventType = typeof(T);
        if (!eventHandlers.ContainsKey(eventType))
        {
            eventHandlers[eventType] = new List<Action<object>>();
        }
        eventHandlers[eventType].Add((e) => handler((T)e));
    }

    public void RemoveListener<T>(Action<T> handler)
    {
        Type eventType = typeof(T);
        if (eventHandlers.ContainsKey(eventType))
        {
            eventHandlers[eventType].Remove((e) => handler((T)e));
            if (eventHandlers[eventType].Count == 0)
            {
                eventHandlers.Remove(eventType);
            }
        }
    }

    public void TriggerEvent<T>(T eventData)
    {
        Type eventType = typeof(T);
        if (eventHandlers.ContainsKey(eventType))
        {
            foreach (var handler in eventHandlers[eventType])
            {
                handler(eventData);
            }
        }
    }
}

// eventType

public class PlayerScoredEvent
{
    public int PlayerID { get; set; }
    public int Score { get; set; }
}

public class GameOverEvent
{
    public string Winner { get; set; }
}

public class BoxColorEvent
{
    public Material Material { get; set; }
}
