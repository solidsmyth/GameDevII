using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Observer
{
  void OnNotify (Object obj, NotificationType noTy);
}



public enum NotificationType
{
  bronzecoin,
  silvercoin,
  goldcoin
}
