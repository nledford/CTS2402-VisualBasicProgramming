Public Class Calculations

    Private amtFat As Integer
    Private amtPro As Integer
    Private amtCarb As Integer
    Private amtTotal As Integer
    Private Shared amtSum As Integer
    Private Shared amtAcumm As Integer

    Public Sub New(ByVal intFat As Integer, ByVal intPro As Integer, ByVal intCarb As Integer)
        amtFat = intFat
        amtPro = intPro
        amtCarb = intCarb
        CalculateTotal()
        CalculateSums()
    End Sub

    Protected Sub CalculateTotal()
        amtTotal = (amtFat * 9) + (amtPro * 4) + (amtCarb * 4)
    End Sub

    Protected Sub CalculateSums()
        amtSum += 1
        amtAcumm += amtTotal
    End Sub

    Property Fat() As Integer
        Get
            Return amtFat
        End Get
        Set(value As Integer)
            amtFat = value
        End Set
    End Property

    Property Protein() As Integer
        Get
            Return amtPro
        End Get
        Set(value As Integer)
            amtPro = value
        End Set
    End Property

    Property Carbs() As Integer
        Get
            Return amtCarb
        End Get
        Set(value As Integer)
            amtCarb = value
        End Set
    End Property

    Property Total() As Integer
        Get
            Return amtTotal
        End Get
        Set(value As Integer)
            amtTotal = value
        End Set
    End Property

    Shared ReadOnly Property TotalSum() As Integer
        Get
            Return amtSum
        End Get
    End Property

    Shared ReadOnly Property TotalAccum() As Integer
        Get
            Return amtAcumm
        End Get
    End Property
End Class
