using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(InputBase))]
public class Player : MonoBehaviour
{
   [SerializeField] private float _moveSpeed = 5f;
   
   private Rigidbody2D _rigidbody;
   private InputBase _input;
   private void Start()
   {
      _rigidbody = GetComponent<Rigidbody2D>();
      _input = GetComponent<InputBase>();
   }

   private void FixedUpdate()
   {
      Move();
   }

   private void Move()
   {
      var movement = _input.GetInput();
      _rigidbody.velocity = new Vector2(movement.x * _moveSpeed, _rigidbody.velocity.y);
   }

   private void Flip()
   {
      
   }
}
