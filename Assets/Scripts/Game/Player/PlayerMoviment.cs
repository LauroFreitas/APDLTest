using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{

    public CharacterController controller;
    public Transform graundChack;
    public LayerMask graundMask;
    private float RunSpeed;
    private float NormalSpeed;
    private float speed;
    private float graundDisitance = 0.4f;
    private float gravidade = -9.81f;
    [HideInInspector]
    public bool isRunning = false;
    private bool isGraunded;
    Vector3 velocity;
  
    
    private void Update()
    {
       // AudioSource source;
      //  source = FindObjectOfType<AudioManager>().sounds[3].source;
        isGraunded = Physics.CheckSphere(graundChack.position, graundDisitance, graundMask);
        //Velocidade de queda
        if (isGraunded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravidade * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            RunSpeed = 24;
            isRunning = true;
            speed = RunSpeed;
         /*
            if (controller.isGrounded == true && controller.velocity.magnitude > 2f && source.isPlaying == false)
            {
                Debug.Log("TESTE");
                source.volume = Random.Range(0.6f, 1f);
                source.pitch = Random.Range(1.4f, 2.3f);
                source.panStereo = Random.Range(-0.5f, 0.5f);
                PlaySoundMove("Andar");
            }
        */
        }
        else
        {
            /*
            if (controller.isGrounded == true && controller.velocity.magnitude > 2f && source.isPlaying == false)
            {
                source.volume = Random.Range(0.4f, 0.6f);
                source.pitch = Random.Range(1, 1.3f);
                PlaySoundMove("Andar");
                Debug.Log("TESTE");
            }
            */
            NormalSpeed = 12;
            isRunning = false;
            speed = NormalSpeed;
        }
    }
    public void PlaySoundMove(string name) 
    {
       //FindObjectOfType<AudioManager>().Play(name);
    }
}
