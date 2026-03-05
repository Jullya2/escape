using UnityEngine;

namespace Minifantasy
{
    public class CameraController : MonoBehaviour
    {
        [Header("Alvo")]
        public Transform player;

        [Header("Configurações")]
        public float smoothSpeed = 0.125f;
        public Vector3 offset = new Vector3(0, 0, -10);

        [Header("Limites Geométricos")]
        public BoxCollider2D bounds; // Arraste o BoxCollider2D para cá

        private float minX, maxX, minY, maxY;

        private void Start()
        {
            if (bounds != null)
            {
                // Calcula os limites baseados no BoxCollider2D
                minX = bounds.bounds.min.x;
                maxX = bounds.bounds.max.x;
                minY = bounds.bounds.min.y;
                maxY = bounds.bounds.max.y;
            }
        }

        private void LateUpdate()
        {
            if (player == null) return;

            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            if (bounds != null)
            {
                // Ajuste opcional: Compensar o tamanho da tel
                float camHeight = Camera.main.orthographicSize;
                float camWidth = camHeight * Camera.main.aspect;

                smoothedPosition.x = Mathf.Clamp(smoothedPosition.x, minX + camWidth, maxX - camWidth);
                smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, minY + camHeight, maxY - camHeight);
            }

            transform.position = smoothedPosition;
        }
    }
}