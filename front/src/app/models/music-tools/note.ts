export interface Note
{
    id :            number;
    octave :        number;
    name :          string;
    enharmony :     string;
    nameFr :        string;
    enharmonyFr :   string;
    frequency :     number;
    alteration :    boolean;
    pressed :       boolean;
    degree :        string;
    degreeName :    string;
    degreeNameFr :  string;
}