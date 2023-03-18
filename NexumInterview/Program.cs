using NexumInterview.Exceptions;
using NexumInterview.Models;
using NexumInterview.Utils;

try
{
    #region Plane Create
    Console.Write("Düzlemin boyutunu X ve Y sırasıyla araya boşluk bırakarak giriniz (örn. 5 5): ");
    string? planeDimension = Console.ReadLine();

    if (string.IsNullOrEmpty(planeDimension))
        throw new BusinessException("Düzlem tanımlaması geçersizdir.");

    Plane plane = new(planeDimension);
    #endregion


    #region Traveller 1 Create
    Console.Write("Gezginin bulunduğu noktayı X, Y ve baktığı yönü araya boşluk bırakarak giriniz (örn. 1 2 N): ");
    string? travellerDimensionAndDirection = Console.ReadLine();

    if (string.IsNullOrEmpty(travellerDimensionAndDirection))
        throw new BusinessException("Gezgin tanımlaması başarısız.");

    Traveller traveller = new(travellerDimensionAndDirection, plane);
    #endregion

    #region TakeMoveLetters For Traveller 1
    Console.Write("Kontrol değerlerini (L, R, M) araya boşluk bırakmadan giriniz (örn. LMRMM): ");
    string? moveLetters = Console.ReadLine();

    char[]? travellerOneMoveLetters = moveLetters?.ToCharArray();

    if (travellerOneMoveLetters == null || !DirectionUtils.CheckMoveLetters(travellerOneMoveLetters))
        throw new BusinessException("Girilen hareket katarı geçersizdir.");
    #endregion

    #region Traveller 1 Move Process
    traveller.Move(travellerOneMoveLetters, plane);
    #endregion


    #region Traveller 2 Create
    Console.Write("2. Gezginin bulunduğu noktayı X, Y ve baktığı yönü araya boşluk bırakarak giriniz (örn. 1 2 N): ");
    string? traveller2DimensionAndDirection = Console.ReadLine();

    if (string.IsNullOrEmpty(traveller2DimensionAndDirection))
        throw new BusinessException("Gezgin tanımlaması başarısız");

    Traveller traveller2 = new(traveller2DimensionAndDirection, plane);
    #endregion

    #region TakeMoveLetters For Traveller 2
    Console.Write("Kontrol değerlerini (L, R, M) araya boşluk bırakmadan giriniz (örn. LMRMM): ");
    string? moveLetters2 = Console.ReadLine();

    char[]? travellerTwoMoveLetters = moveLetters2?.ToCharArray();

    if (travellerTwoMoveLetters == null || !DirectionUtils.CheckMoveLetters(travellerTwoMoveLetters))
        throw new BusinessException("Girilen hareket katarı geçersizdir.");
    #endregion

    #region Traveller 2 Move Process
    traveller2.Move(travellerTwoMoveLetters, plane);
    #endregion

    traveller.GetCurrentInfo();
    traveller2.GetCurrentInfo();
}
catch (BusinessException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception)
{
    Console.WriteLine("Sistemin çalışmasına engel bir durum gerçekleşti");
}
finally
{
    Console.ReadLine();
}