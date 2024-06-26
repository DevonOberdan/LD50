using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventSystem
{
    [CreateAssetMenu(fileName = "NewGameEvent", menuName = "Game Event")]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventInvoked();
        }

        public void RegisterListener(GameEventListener listener) => listeners.Add(listener);
        public void UnregisterListener(GameEventListener listener) => listeners.Remove(listener);
    }
}