using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarakoKutibiru.UnityExtensions.Samples
{
    [RequireComponent(typeof(Rigidbody))]
    public class Character : MonoBehaviour
    {
        [SerializeField] Rigidbody rb;
        [SerializeField] float     speed     = 10.0f;
        [SerializeField] float     jumpPower = 10.0f;

        [SerializeField] ParticleSystem particlePrefab;

        void Update()
        {
            if (this.IsOnGround())
            {
                Vector2 inputDirection = GetInputDirection();
                if (inputDirection.sqrMagnitude <= 0.1f)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        this.rb.velocity = this.rb.velocity.SetY(this.jumpPower);
                    }
                    else
                    {
                        this.rb.velocity = this.rb.velocity.SetX(0).SetZ(0);
                    }
                }
                else
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        this.rb.velocity = inputDirection.ToVector3X0Y().Multiply(this.speed).SetY(this.jumpPower);
                    }
                    else
                    {
                        this.rb.velocity = inputDirection.ToVector3X0Y().Multiply(this.speed).SetY(this.rb.velocity.y);
                    }
                }
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            this.PlayParticle();
        }

        public void PlayParticle()
        {
            this.particlePrefab.Instantiate<ParticleSystem>(this.transform.position.SetY(0.0f), Quaternion.AngleAxis(-90, Vector3.left));

            // Or
            // this.particlePrefab.Instantiate<ParticleSystem>().transform.SetPosition(this.transform.position.SetY(0.0f)).SetRotation(Quaternion.AngleAxis(-90, Vector3left));
        }

        bool IsOnGround()
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);
                Debug.Log("Did Hit");
                return hit.distance <= 0.6f;
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 1000, Color.white);
                Debug.Log("Did not Hit");
                return false;
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
