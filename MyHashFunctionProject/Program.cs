string txt = "lorem ipsum dolo";
int hashValue = 0;

for (int i = 0; i < 4; i++)
{
    string txtPiece = CuttingText(txt, 4);
    string binaryValue = GettingBinaryValueOfReversedStr(txtPiece);
    int decimalValue = GetDecimalValueFromBinaryString(binaryValue);
    Console.WriteLine(decimalValue);
    Console.WriteLine(binaryValue);
    hashValue += decimalValue;
    txt = txt.Substring(4);
}

Console.WriteLine($"Hash Value is: {hashValue}");

string CuttingText(string text, int count)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text[i];
        //Console.WriteLine((int)text[i]);

    }
    return result;
}

string GettingBinaryValueOfReversedStr(string txtPiece)
{
    string binaryConcatenation = string.Empty;
    for (int i = txtPiece.Length - 1; i >= 0; i--)
    {
        int charCode = (int)txtPiece[i];
        string binaryCode = Convert.ToString(charCode, 2).PadLeft(8, '0');
        binaryConcatenation += binaryCode;
    }

    return binaryConcatenation;
}

int GetDecimalValueFromBinaryString(string binaryString)
{
    int decimalValue = 0;
    int length = binaryString.Length;
    for (int i = 0; i < length; i++)
    {
        if (binaryString[length - 1 - i] == '1')
        {
            decimalValue += (int)Math.Pow(2, i);
        }
    }
    return decimalValue;
}

//string input = string.Empty;

//while (!input.Equals("quit"))
//{
//    Console.WriteLine("> ");
//    input = Console.ReadLine();

//    Console.WriteLine($"Folding: {FoldingHash(input)}");
//}

//static int FoldingHash(string input)
//{
//    int hashValue = 0;
//    int startIndex = 0;
//    int currentFourBytes;

//    do
//    {
//        currentFourBytes = GetNextBytes(startIndex, input);
//        unchecked
//        {
//            hashValue += currentFourBytes;
//        }

//        startIndex += 4;

//    } while (currentFourBytes != 0);

//    return hashValue;
//}
//static int GetNextBytes(int startIndex, string str)
//{
//    int currentFourBytes = 0;

//    currentFourBytes += GetByte(str, startIndex);
//    currentFourBytes += GetByte(str, startIndex + 1) << 8;
//    currentFourBytes += GetByte(str, startIndex + 2) << 16;
//    currentFourBytes += GetByte(str, startIndex + 3) << 24;
//    //for (int i = 0; i < 4; i++)
//    //{
//    //    if (startIndex + i < input.Length)
//    //    {
//    //        value |= (input[startIndex + i] << (i * 8));
//    //    }
//    //}
//    //return value;

//    return currentFourBytes;
//}

//static int GetByte(string str, int index)
//{
//    if (index < str.Length)
//    {
//        return (int)str[index];
//    }

//    return 0;
//}

