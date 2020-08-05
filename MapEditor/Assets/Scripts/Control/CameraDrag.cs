using System;
using UnityEngine;

namespace Control
{
    [RequireComponent(typeof(Camera))]
    public class CameraDrag : MonoBehaviour
    {
        public int panSpeed = 120;

        private Vector3 _mouseOrigin;
        private bool _isPanning;
        private Camera _camera;

        private void Awake()
        {
            _camera = GetComponent<Camera>();
        }

        private void Update()
        {
            /*if (Input.GetMouseButtonDown(1))
            {
                _mouseOrigin = Input.mousePosition;
                _isPanning = true;
            }

            if (!Input.GetMouseButton(1))
                _isPanning = false;

            if (_isPanning)
            {
                var pos = _camera.ScreenToViewportPoint(Input.mousePosition - _mouseOrigin);
                
                // Update only x and y
                var move = new Vector3(pos.x * panSpeed, pos.y * panSpeed, 0);
                
                _camera.transform.Translate(move, Space.Self);
            }*/

            if (Input.GetMouseButton(1))
            {
                var speed = panSpeed * Time.deltaTime;
                _camera.transform.position -=
                    new Vector3(Input.GetAxis("Mouse X") * speed, Input.GetAxis("Mouse Y") * speed);
            }
        }
    }
}
