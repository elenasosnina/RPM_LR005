﻿//https://docs.google.com/document/d/1P3kBxfRo420TN9bADSITAmdnIWRJUrNsCpj2ENN1YQs/edit

using System;
namespace ClassLibrary1;

public class Competence
{
	public int code;
	public string content;
	public readonly Speciality speciality;
	public Speciality Speciality { get => speciality; }
	public Competence(int code, string content, Speciality speciality)
	{
		this.code = code;
		this.content = content;
		this.speciality = speciality;
	}
}