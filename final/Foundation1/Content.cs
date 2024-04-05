using System;
using System.Collections.Generic;

public abstract class Content
{
    public string _title { get; set;}
    public string _author { get; set;}
    public int _length { get; set;}

    public abstract int GetNumberOfComments();
}