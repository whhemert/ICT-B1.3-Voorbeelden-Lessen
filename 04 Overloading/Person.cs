﻿namespace Overloading;

internal class Person
{
	private string _name;
	private DateTime _dateOfBirth;

	// Constructors
	public Person(string name) : this(name, DateTime.UnixEpoch)
	{
		// Empty constructor body, base constructor is called
	}

	public Person(string name, DateTime dateOfBirth)
	{
		_name = name;
		_dateOfBirth = dateOfBirth;
	}

	// Properties
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	public DateTime DateOfBirth
	{
		get { return _dateOfBirth; }
		set { _dateOfBirth = value; }
	}

	// Methodes om geboortedatum bij te werken
	public void UpdateDateOfBirth(DateTime dateOfBirth)
	{
		_dateOfBirth = dateOfBirth;
	}

	public void UpdateDateOfBirth(int year, int month, int day)
	{
		_dateOfBirth = new DateTime(year, month, day);
	}

	public bool UpdateDateOfBirth(string dateOfBirth)
	{
		if (DateTime.TryParse(dateOfBirth, out DateTime parsedDate))
		{
			_dateOfBirth = parsedDate;
			return true;
		}

		Console.WriteLine("Ongeldige datumformaat. Verwacht formaat: 'YYYY-MM-DD'.");
		return false;
	}
}
