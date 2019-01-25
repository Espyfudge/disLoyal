using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerScore {

	private static float p1score1, p2score1, p1score2, p2score2, f1score, f2score, c1score, c2score;
	private static bool secondDay, tcFinished, ocFinished;
	private static int d1Found, d2Done;

	public static float P1score1 {
		get {
			return p1score1;
		}
		set {
			p1score1 = value;
		}
	}

	public static float P2score1 {
		get {
			return p2score1;
		}
		set {
			p2score1 = value;
		}
	}

	public static float P1score2 {
		get {
			return p1score2;
		}
		set {
			p1score2 = value;
		}
	}

	public static float P2score2 {
		get {
			return p2score2;
		}
		set {
			p2score2 = value;
		}
	}

	public static bool SecondDay {
		get {
			return secondDay;
		}
		set {
			secondDay = value;
		}
	}

	public static bool TCFinished {
		get {
			return tcFinished;
		}
		set {
			tcFinished = value;
		}
	}

	public static bool OCFinished {
		get {
			return ocFinished;
		}
		set {
			ocFinished = value;
		}
	}

	public static int D1Found {
		get {
			return d1Found;
		}
		set {
			d1Found = value;
		}
	}

	public static int D2Done {
		get {
			return d2Done;
		}
		set {
			d2Done = value;
		}
	}

	public static float F1Score {
		get {
			return f1score;
		}
		set {
			f1score = value;
		}
	}

	public static float F2Score {
		get {
			return f2score;
		}
		set {
			f2score = value;
		}
	}

	public static float C1Score {
		get {
			return c1score;
		}
		set {
			c1score = value;
		}
	}

	public static float C2Score {
		get {
			return c2score;
		}
		set {
			c2score = value;
		}
	}
}
