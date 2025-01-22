using ServiceLocator.Player;
using UnityEngine;

/**  This script demonstrates implementation of the Observer Pattern.
  *  If you're interested in learning about Observer Pattern, 
  *  you can find a dedicated course on Outscal's website.
  *  Link: https://outscal.com/courses
  **/

namespace ServiceLocator.Events
{
    public class EventService : MonoBehaviour
    {
        public GameEventController<int> OnMapSelected { get; private set; }
        public static EventService Instance { get { return instance; } }
        private static EventService instance;
        

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this.gameObject);
            }
            OnMapSelected = new GameEventController<int>();
        }
        
        
    }
}