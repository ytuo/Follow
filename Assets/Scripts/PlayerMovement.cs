using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRStandardAssets.Utils {
    public class PlayerMovement : MonoBehaviour
    {

        public int movespeed = 4;
        public float maxspeed;
        public float jumpforce;
        public float projectileSpeed;
        public GameObject playerProjectile;
        public bool bodyContact;
        public bool feetContact;
        public float clockwise = 40.0f;
        public float counterClockwise = -40.0f;
        public new Camera camera;

        Rigidbody2D playerRB;
        private bool facingRight = true;
        /*
        private float currentVelocity = 0f;
        private float maxVelocity = 5f;
        private float acceleration = 2f;
        */

        // Constants
        private static float projectileDestroyTime = 5;

        void Awake()
        {
            playerRB = gameObject.GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            ForwardMovement();
            
            /*
            float MoveHor = Input.GetAxisRaw("Horizontal");
            float MoveVert = Input.GetAxisRaw("Vertical");
            Vector2 movement = new Vector2(MoveHor * movespeed, 0);
            //transform.position += new Vector3(MoveVert * movespeed * Time.deltaTime, 0, MoveHor * movespeed * Time.deltaTime);
            //movement = movement * Time.deltaTime;
            if (MoveVert > 0)
            {
                transform.position += transform.forward * Time.deltaTime * movespeed;
            }
            else if (MoveVert < 0)
            {
                transform.position += -transform.forward * Time.deltaTime * movespeed;
            }
            else if (MoveHor < 0)
            {
                transform.position += -transform.right * Time.deltaTime * movespeed;
            }
            else if (MoveHor > 0)
            {
                transform.position += transform.right * Time.deltaTime * movespeed;
            }

            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(0, Time.deltaTime * clockwise, 0);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
            }

            //playerRB.AddForce(movement);
            if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
            {
                facingRight = false;
            }
            if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
            {
                facingRight = true;
            }

            if (playerRB.velocity.x > maxspeed)
            {
                playerRB.velocity = new Vector2(maxspeed, playerRB.velocity.y);
            }
            if (playerRB.velocity.x < -maxspeed)
            {
                playerRB.velocity = new Vector2(-maxspeed, playerRB.velocity.y);
            }
            if (Input.GetKeyDown(KeyCode.Space) && canJump())
            {
                playerRB.velocity = new Vector2(playerRB.velocity.x, 0);
                playerRB.AddForce(new Vector2(0, jumpforce));
            }
            if (Input.GetKeyDown("f"))
            {
                Vector2 firingDirection;
                GameObject projectile = (GameObject)Instantiate
                    (playerProjectile, transform.position, transform.rotation);
                if (facingRight)
                {
                    firingDirection = new Vector2(projectileSpeed, 0);
                }
                else
                {
                    firingDirection = new Vector2(-projectileSpeed, 0);
                }
                projectile.GetComponent<Rigidbody2D>().velocity = firingDirection;
                Destroy(projectile, projectileDestroyTime);
            }
            */

        }

        void ForwardMovement()
        {
            //Define the forward vector using your facing direction
            Vector3 forward = camera.transform.forward;
            forward = new Vector3(forward.x, 0, forward.z).normalized * Time.deltaTime * 3;

            // The touchpad is button 0. If the touchpad is being held down...
            if (Input.GetMouseButton(0))
            {
                transform.position += forward;
            }
            /*
            // If the touchpad was released on this frame, stop movement and reset current speed.
            if (Input.GetMouseButtonUp(0))
            {
                currentVelocity = 0.0F;
            }
            */
        }

        bool canJump()
        {
            return feetContact;
            //Task 2
        }

    }

}
