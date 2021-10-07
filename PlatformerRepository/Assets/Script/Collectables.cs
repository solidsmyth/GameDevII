using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectables : SubjectBeingObserved
{
  //used to create subclasses of various collectables
  protected int pointValue;
  protected string objName;
}
