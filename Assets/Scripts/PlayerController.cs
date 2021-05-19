using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]

public class PlayerController : MonoBehaviour
{
   [SerializeField]
   private float speed = 3f;

   private PlayerMotor motor;

   private void Start()
   {
       motor = GetComponent<PlayerMotor>();
   }

   private void Update()
   {
       // calcul
       float xMove = Input.GetAxisRaw("Horizontal");
       float zMove = Input.GetAxisRaw("Vertical");

       // applique
       Vector3 moveHorizontal = transform.right * xMove;
       Vector3 moveVertical = transform.forward * zMove;

       // resultat
       Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

       // appel
       motor.Move(velocity);
       
   }
}
