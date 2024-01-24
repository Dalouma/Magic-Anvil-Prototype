using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingScript : MonoBehaviour
{
    [SerializeField] private float cursorMovementSpeed;

    [SerializeField] private Transform cursorTransform;

    [SerializeField] private Transform greatLeft;
    [SerializeField] private Transform greatRight;

    [SerializeField] private Transform goodLeft;
    [SerializeField] private Transform goodRight;

    [SerializeField] private Transform badLeft;
    [SerializeField] private Transform badRight;

    [SerializeField] private Transform EndLeft;
    [SerializeField] private Transform EndRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Valid Inputs
        bool LMB = Input.GetMouseButtonDown(0);
        bool RMB = Input.GetMouseButtonDown(1);
        // Might use later ^^^^^

        float cursorPos = cursorTransform.position.x;

        cursorTransform.position += Vector3.right * cursorMovementSpeed * Time.deltaTime;

        // Change Directions
        if (cursorTransform.position.x > EndRight.position.x || cursorTransform.position.x < EndLeft.position.x)
        {
            cursorMovementSpeed *= -1;
        }

        // Check Click Timing
        if (Input.anyKeyDown)
        {
            StartCoroutine(SlowMo());
            
            // Check Zones
            if (cursorPos >= greatLeft.position.x && cursorPos <= greatRight.position.x)
            {
                Debug.Log("GREAT TIMING!!");
            }
            else if (cursorPos >= goodLeft.position.x && cursorPos <= goodRight.position.x)
            {
                Debug.Log("GOOD TIMING!");
            }
            else if (cursorPos >= badLeft.position.x && cursorPos <= badRight.position.x)
            {
                Debug.Log("BAD TIMING");
            }
            else
            {
                Debug.Log("FAIL");
            }
        }
    }

    private IEnumerator SlowMo()
    {
        Debug.Log("SlowMo");
        cursorMovementSpeed *= 0.3f;
        yield return new WaitForSeconds(0.1f);
        cursorMovementSpeed *= 1/0.3f;
    }

}
