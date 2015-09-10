Public Class frmWestEndOrder

    ' Class level constants as decimal values
    Const TAX_RATE As Decimal = 0.0875D '8.75% tax rate

    Const PRICE_RIBEYE_SANDWICH As Decimal = 7.5D
    Const PRICE_LOBSTER As Decimal = 22D
    Const PRICE_HOKIE_CLUB As Decimal = 6.5D
    Const PRICE_PUB_BURGER As Decimal = 5D

    Const PRICE_CHEESE As Decimal = 0.5D
    Const PRICE_TOMATO As Decimal = 0.2D

    Const PRICE_WATER As Decimal = 0.05D
    Const PRICE_SODA As Decimal = 1.25D
    Const PRICE_JUICE As Decimal = 1D
    Const PRICE_SMOOTHIE As Decimal = 2.5D

    Const PRICE_FRENCH_FRIES As Decimal = 1.5D
    Const PRICE_MOZZARELLA_STICKS As Decimal = 3D

    'Class level variables
    Dim subtotal As Decimal
    Dim tax As Decimal
    Dim total As Decimal

    'Form load event
    Private Sub frmWestEndOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeVariables()
        ClearCustomerSelections()
        ClearReceipt()
    End Sub

    Private Sub InitializeVariables() 'for each new customer
        subtotal = 0
        tax = 0
        total = 0
    End Sub

    Private Sub ClearCustomerSelections() 'for each new customer
        chkCheese.Checked = False
        chkTomato.Checked = False
        chkMozzSticks.Checked = False
        chkFries.Checked = False

        radWater.Checked = True
        radWater.Checked = False
        radRibeyeSandwich.Checked = True
        radRibeyeSandwich.Checked = False
    End Sub

    Private Sub ClearReceipt()
        lstTotal.Items.Clear()
        lstOrderReceipt.Items.Clear()
    End Sub

    Private Sub ComputeCurrentSelection()
        If radRibeyeSandwich.Checked Then
            subtotal += PRICE_RIBEYE_SANDWICH
            Dim RibeyeSandwichItem As String =
                PRICE_RIBEYE_SANDWICH.ToString("C") & " - Ribeye Sandwich"
            lstOrderReceipt.Items.Add(RibeyeSandwichItem)
        End If
        If radLobster.Checked Then
            subtotal += PRICE_LOBSTER
            Dim LobsterItem As String =
                PRICE_LOBSTER.ToString("C") & " - Lobster"
            lstOrderReceipt.Items.Add(LobsterItem)
        End If
        If radHokieClub.Checked Then
            subtotal += PRICE_HOKIE_CLUB
            Dim HokieClubItem As String =
                PRICE_HOKIE_CLUB.ToString("C") & " - Hokie Club"
            lstOrderReceipt.Items.Add(HokieClubItem)
        End If
        If radPubBurger.Checked Then
            subtotal += PRICE_PUB_BURGER
            Dim PubBurgerItem As String =
                PRICE_PUB_BURGER.ToString("C") & " - Pub Burger"
            lstOrderReceipt.Items.Add(PubBurgerItem)
        End If

        If chkCheese.Checked Then
            subtotal += PRICE_CHEESE
            Dim CheeseItem As String =
                PRICE_CHEESE.ToString("C") & " - Cheese"
            lstOrderReceipt.Items.Add(CheeseItem)
        End If
        If chkTomato.Checked Then
            subtotal += PRICE_TOMATO
            Dim TomatoItem As String =
                PRICE_TOMATO.ToString("C") & " - Tomato"
            lstOrderReceipt.Items.Add(TomatoItem)
        End If

        If radWater.Checked Then
            subtotal += PRICE_WATER
            Dim WaterItem As String =
                PRICE_WATER.ToString("C") & " - Water"
            lstOrderReceipt.Items.Add(WaterItem)
        End If
        If radSoda.Checked Then
            subtotal += PRICE_SODA
            Dim SodaItem As String =
                PRICE_SODA.ToString("C") & " - Soda"
            lstOrderReceipt.Items.Add(SodaItem)
        End If
        If radJuice.Checked Then
            subtotal += PRICE_JUICE
            Dim JuiceItem As String =
                PRICE_JUICE.ToString("C") & " - Juice"
            lstOrderReceipt.Items.Add(JuiceItem)
        End If
        If radSmoothie.Checked Then
            subtotal += PRICE_SMOOTHIE
            Dim SmoothieItem As String =
                PRICE_SMOOTHIE.ToString("C") & " - Smoothie"
            lstOrderReceipt.Items.Add(SmoothieItem)
        End If

        If chkFries.Checked Then
            subtotal += PRICE_FRENCH_FRIES
            Dim FrenchFriesItem As String =
                PRICE_FRENCH_FRIES.ToString("C") & " - French Fries"
            lstOrderReceipt.Items.Add(FrenchFriesItem)
        End If
        If chkMozzSticks.Checked Then
            subtotal += PRICE_MOZZARELLA_STICKS
            Dim MozzSticksItem As String =
                PRICE_MOZZARELLA_STICKS.ToString("C") & " - Mozzarella Sticks"
            lstOrderReceipt.Items.Add(MozzSticksItem)
        End If

    End Sub

    Private Sub UpdateTotal()
        lstTotal.Items.Clear()
        lstTotal.Items.Add("SUB TOTAL = " & subtotal.ToString("C"))
        'tax = subtotal * TAX_RATE
        'lstTotal.Items.Add("     TAX = " & tax.ToString("C"))
        'total = subtotal + tax
        'lstTotal.Items.Add("     TOTAL = " & total.ToString("C"))

        lstOrderReceipt.Items.Add("---------------")
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        ComputeCurrentSelection()
        UpdateTotal()
        ClearCustomerSelections()
    End Sub

    'Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    '    InitializeVariables()
    '    ClearCustomerSelections()
    '    ClearReceipt()
    'End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
