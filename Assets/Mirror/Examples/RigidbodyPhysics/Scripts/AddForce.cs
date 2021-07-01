using UnityEngine;

namespace Mirror.Examples.RigidbodyPhysics
{
    public class AddForce : NetworkBehaviour
    {
        public Rigidbody rigidbody3d;
        public float force = 500f;

        // void Start()
        // {
        //     rigidbody3d.isKinematic = !isServer;
        //     rigidbody3d.isKinematic = !isClient;
        // }

        void Update()
        {
            if (isLocalPlayer)
            {
                if (isServer && Input.GetKeyDown(KeyCode.Space))
                {
                    rigidbody3d.AddForce(Vector3.up * force);
                    
                }
            if (isClient && Input.GetKeyDown(KeyCode.Space))
                {
                    rigidbody3d.AddForce(Vector3.up * force);
                }
            }
            
            
        }
    }
}
