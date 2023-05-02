//https://docs.google.com/document/d/1P3kBxfRo420TN9bADSITAmdnIWRJUrNsCpj2ENN1YQs/edit

using System;
namespace ClassLibrary1;

public class Competence
{
	public string Code { get; }
	public string Content { get; }
	public Speciality Speciality { get; }
	public Competence(string code, string content, Speciality speciality)
	{
		this.Code = code;
		this.Content = content;
		this.Speciality = speciality;
	}
}