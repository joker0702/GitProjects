// Ausgabe test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

int _tmain(int argc, _TCHAR* argv[])
{
	const char hw[] = "Hallo, Welt!";
	char* video = (char*)0xb8000;

	for (size_t i = 0; hw[i] != '\0'; i++)
	{
		video[i * 2] = hw[i];
		video[i * 2 + 1] = 0x07;
	}
}

