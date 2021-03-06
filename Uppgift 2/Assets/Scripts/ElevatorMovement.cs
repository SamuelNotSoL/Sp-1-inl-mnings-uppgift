using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour {

    [SerializeField] private GameObject nextTarget;

    [SerializeField] private float speed = 2f;

    [SerializeField] private List<GameObject> targetPoints;
    private int currentTargetPointIndex;

    // Start is called before the first frame update
    void Start() {

        if (targetPoints.Count > 0) {
            nextTarget = targetPoints[0];
        }
    }    

    // Update is called once per frame
    void FixedUpdate() {

        if (nextTarget != null) {
            MoveToPosition(nextTarget);
        }
    }
    private void MoveToPosition(GameObject moveToTarget) {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, moveToTarget.transform.position, speed * Time.fixedDeltaTime);
        if (gameObject.transform.position == moveToTarget.transform.position) {
            ChangeTarget();
        }
    }  //kan inte komma på varför den inte vill byta till point2
    private void ChangeTarget() {

        //point1 = index 0
        //point2 = index 1
        //point3 = index 2
        //null   = index 3 

        currentTargetPointIndex++;

        while (targetPoints[currentTargetPointIndex] == null) {
            currentTargetPointIndex++;
            if (currentTargetPointIndex >= targetPoints.Count) {
                currentTargetPointIndex = 0;
            }
        }
        nextTarget = targetPoints[currentTargetPointIndex];
    }
}