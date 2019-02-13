using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  ScoreTextSript.coinAmount += 1;
  Destroy(cube);
}
