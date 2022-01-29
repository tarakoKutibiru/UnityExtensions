using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarakoKutibiru.UnityExtensions.Samples
{
    [RequireComponent(typeof(Rigidbody))]
    public class Character : MonoBehaviour
    {
        [SerializeField] Rigidbody rb;
        [SerializeField] float     speed = 10.0f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var inputDirection = GetInputDirection();
            if (inputDirection.sqrMagnitude <= 0.1f)
            {
                this.rb.velocity = Vector3.zero;
            }
            else
            {
                this.rb.velocity = inputDirection.ToVector3X0Y().Multiply(this.speed).SetY(this.rb.velocity.y);
            }
        }

        public Vector2 GetInputDirection()
        {
            var d = Vector2.zero;

            if (Input.GetKey(KeyCode.W))
            {
                d.y += 1;
            }

            if (Input.GetKey(KeyCode.S))
            {
                d.y -= 1;
            }

            if (Input.GetKey(KeyCode.A))
            {
                d.x -= 1;
            }

            if (Input.GetKey(KeyCode.D))
            {
                d.x += 1;
            }

            d.Normalize();
            return d;
        }

        #if UNITY_EDITOR
        void Reset()
        {
            this.rb = this.GetComponent<Rigidbody>();
        }
        #endif
    }
}
