Public Class FormNewCars
    Dim grsupra As Double = 5396000
    Dim gr86 As Double = 2320000
    Dim gryaris As Double = 2940000
    Dim grcorolla As Double = 1302000
    Dim gr8624 As Double = 2328000
    Dim camry As Double = 2442000
    Dim yaris As Double = 1199000
    Dim corolla As Double = 1135000
    Dim yariscross As Double = 1199000
    Dim rav4 As Double = 2289000
    Dim innova As Double = 1261000
    Dim vios As Double = 732000
    Dim priusprime As Double = 1612000
    Dim tax As Double = 0.1
    Dim totalCost As Double
    Private Sub CalculateCost()

        If optGRSupra.Checked = True Then
            price.Text = grsupra
            totalCost = grsupra
        ElseIf optGR86.Checked = True Then
            price.Text = gr86
            totalCost = gr86
        ElseIf optGRYaris.Checked = True Then
            price.Text = gryaris
            totalCost = gryaris
        ElseIf optGRCorolla.Checked = True Then
            price.Text = grcorolla
            totalCost = grcorolla
        ElseIf optGR8624.Checked = True Then
            price.Text = gr8624
            totalCost = gr8624
        ElseIf optcamry.Checked = True Then
            price.Text = camry
            totalCost = camry
        ElseIf optyaris.Checked = True Then
            price.Text = yaris
            totalCost = yaris
        ElseIf optcorolla.Checked = True Then
            price.Text = corolla
            totalCost = corolla
        ElseIf optyariscross.Checked = True Then
            price.Text = yariscross
            totalCost = yariscross
        ElseIf optrav4.Checked = True Then
            price.Text = rav4
            totalCost = rav4
        ElseIf optInnova.Checked = True Then
            price.Text = innova
            totalCost = innova
        ElseIf optVIOS.Checked = True Then
            price.Text = vios
            totalCost = vios
        ElseIf optPrius.Checked = True Then
            price.Text = priusprime
            totalCost = priusprime
        Else
            Return
            End If
            Dim taxAmount As Double = totalCost * tax
            totalCost += taxAmount
        vat.Text = taxAmount
        txttotalcost.Text = totalCost
        Return
    End Sub

    Private Sub optGRSupra_CheckedChanged(sender As Object, e As EventArgs) Handles optGRSupra.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota GR Supra RZ '24"
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Stratosphere Blue")
        CheckoutNew.cbColours.Items.Add("Absolute Zero White")
        CheckoutNew.cbColours.Items.Add("Nocturnal Black")
        CheckoutNew.cbColours.Items.Add("Renaissance Red")
        Main.InfoModel.Text = "Toyota GR Supra RZ '24"
        Main.InfoHorsepower.Text = "335 hp @ 5000 - 6500 rpm"
        Main.InfoDisplacement.Text = "2998cc"
        Main.InfoPowertrain.Text = "FR"
    End Sub

    Private Sub FormNewCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optGRSupra.Checked = False
        optGR86.Checked = False
        optGRYaris.Checked = False
        optGRCorolla.Checked = False
        optGR8624.Checked = False
        optCamry.Checked = False
        optYaris.Checked = False
        optCorolla.Checked = False
        optYarisCross.Checked = False
        optRAV4.Checked = False
        optInnova.Checked = False
        optVIOS.Checked = False
        optPrius.Checked = False
    End Sub

    Private Sub optGR86_CheckedChanged(sender As Object, e As EventArgs) Handles optGR86.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota GR86 '23"
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("White Liquid")
        CheckoutNew.cbColours.Items.Add("Ice Silver Metallic")
        CheckoutNew.cbColours.Items.Add("Storm Black")
        CheckoutNew.cbColours.Items.Add("Apollo Blue")
        CheckoutNew.cbColours.Items.Add("Magnetic Grey")
        CheckoutNew.cbColours.Items.Add("Rapid Blue")
        CheckoutNew.cbColours.Items.Add("Spark Red")
        Main.InfoModel.Text = "Toyota GR86 '23"
        Main.InfoHorsepower.Text = "228 hp @ 7000 rpm"
        Main.InfoDisplacement.Text = "2387cc"
        Main.InfoPowertrain.Text = "FR"
    End Sub

    Private Sub optGRYaris_CheckedChanged(sender As Object, e As EventArgs) Handles optGRYaris.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota GR Yaris '24"
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Emotional Red")
        CheckoutNew.cbColours.Items.Add("Precious Black")
        CheckoutNew.cbColours.Items.Add("Super White/Platinum White Pearlescent")
        Main.InfoModel.Text = "Toyota GR Yaris '24"
        Main.InfoHorsepower.Text = "257 hp @ 6500 rpm"
        Main.InfoDisplacement.Text = "2300cc"
        Main.InfoPowertrain.Text = "4WD"
    End Sub

    Private Sub optGRCorolla_CheckedChanged(sender As Object, e As EventArgs) Handles optGRCorolla.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota GR Corolla '24"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Glacier White")
        CheckoutNew.cbColours.Items.Add("Ebony")
        CheckoutNew.cbColours.Items.Add("Feverish Red")
        CheckoutNew.cbColours.Items.Add("Liquid Mercury")
        Main.InfoModel.Text = "Toyota GR Corolla '24"
        Main.InfoHorsepower.Text = "300 hp @ 6500 rpm"
        Main.InfoDisplacement.Text = "2618cc"
        Main.InfoPowertrain.Text = "4WD"
    End Sub

    Private Sub optGR8624_CheckedChanged(sender As Object, e As EventArgs) Handles optGR8624.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota GR86 '24"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Classic Two-Tone White and Black")
        CheckoutNew.cbColours.Items.Add("White Liquid")
        CheckoutNew.cbColours.Items.Add("Ice Silver Metallic")
        CheckoutNew.cbColours.Items.Add("Storm Black")
        CheckoutNew.cbColours.Items.Add("Apollo Blue")
        CheckoutNew.cbColours.Items.Add("Magnetic Grey")
        CheckoutNew.cbColours.Items.Add("Rapid Blue")
        CheckoutNew.cbColours.Items.Add("Spark Red")
        Main.InfoModel.Text = "Toyota GR86 '24"
        Main.InfoHorsepower.Text = "230 hp @ 7000 rpm"
        Main.InfoDisplacement.Text = "2387cc"
        Main.InfoPowertrain.Text = "FR"
    End Sub

    Private Sub optCamry_CheckedChanged(sender As Object, e As EventArgs) Handles optCamry.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota Camry '24"
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Cavalry Blue")
        CheckoutNew.cbColours.Items.Add("Predawn Gray Mica")
        CheckoutNew.cbColours.Items.Add("Ice Edge")
        CheckoutNew.cbColours.Items.Add("Ice Cap")
        CheckoutNew.cbColours.Items.Add("Midnight Black Metallic")
        CheckoutNew.cbColours.Items.Add("Reservoir Blue")
        CheckoutNew.cbColours.Items.Add("Celestial Silver Metallic")
        CheckoutNew.cbColours.Items.Add("Celestial Silver Metallic with Midnight Black Metallic Roof")
        CheckoutNew.cbColours.Items.Add("Spark Red")
        Main.InfoModel.Text = "Toyota Camry '24"
        Main.InfoHorsepower.Text = "203 hp @ 6600 rpm"
        Main.InfoDisplacement.Text = "1960cc"
        Main.InfoPowertrain.Text = "FF"
    End Sub

    Private Sub optYaris_CheckedChanged(sender As Object, e As EventArgs) Handles optYaris.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        CheckoutNew.lblCar.Text = "Toyota Yaris '23"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Wildfire Red")
        CheckoutNew.cbColours.Items.Add("Phantom Brown")
        CheckoutNew.cbColours.Items.Add("Wildfire Red With Attitude Black")
        CheckoutNew.cbColours.Items.Add("Pearl White")
        CheckoutNew.cbColours.Items.Add("Silver Metallic With Attitude Black")
        CheckoutNew.cbColours.Items.Add("Super White With Attitude Black")
        CheckoutNew.cbColours.Items.Add("Grey Metallic")
        CheckoutNew.cbColours.Items.Add("Silver Metallic")
        Main.lblTotalCost.Text = txttotalcost.Text
        Main.InfoModel.Text = "Toyota Yaris '23"
        Main.InfoHorsepower.Text = "116 hp @ 3600 rpm"
        Main.InfoDisplacement.Text = "1490cc"
        Main.InfoPowertrain.Text = "FF"
    End Sub

    Private Sub optCorolla_CheckedChanged(sender As Object, e As EventArgs) Handles optCorolla.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota Corolla Altis '24"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Attitude Black")
        CheckoutNew.cbColours.Items.Add("Phantom Brown")
        CheckoutNew.cbColours.Items.Add("White Pearl")
        CheckoutNew.cbColours.Items.Add("Red Mica Metallic")
        CheckoutNew.cbColours.Items.Add("Silver Metallic")
        Main.InfoModel.Text = "Toyota Corolla Altis '24"
        Main.InfoHorsepower.Text = "132 hp @ 6400 rpm"
        Main.InfoDisplacement.Text = "1798cc"
        Main.InfoPowertrain.Text = "FF"
    End Sub

    Private Sub optYarisCross_CheckedChanged(sender As Object, e As EventArgs) Handles optYarisCross.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota Yaris Cross '24"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("White Pearl")
        CheckoutNew.cbColours.Items.Add("Dark Turquoise SE")
        CheckoutNew.cbColours.Items.Add("Greenish Gun Metal")
        CheckoutNew.cbColours.Items.Add("Scarlet SE")
        Main.InfoModel.Text = "Toyota Yaris Cross '24"
        Main.InfoHorsepower.Text = "86 hp @ 5500 rpm"
        Main.InfoDisplacement.Text = "1496cc"
        Main.InfoPowertrain.Text = "4WD"
    End Sub

    Private Sub optRAV4_CheckedChanged(sender As Object, e As EventArgs) Handles optRAV4.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota RAV4 Hybrid'24"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Army Green")
        CheckoutNew.cbColours.Items.Add("Blueprint")
        CheckoutNew.cbColours.Items.Add("Cavalry Blue")
        CheckoutNew.cbColours.Items.Add("Ice Cap")
        Main.InfoModel.Text = "Toyota RAV4 Hybrid'24"
        Main.InfoHorsepower.Text = "170 hp @ 5700 rpm"
        Main.InfoDisplacement.Text = "2487cc"
        Main.InfoPowertrain.Text = "4WD"
    End Sub

    Private Sub optInnova_CheckedChanged(sender As Object, e As EventArgs) Handles optInnova.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota Innova '24"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Blackish Red Mica")
        CheckoutNew.cbColours.Items.Add("Black")
        CheckoutNew.cbColours.Items.Add("Alumina Jade Metallic")
        CheckoutNew.cbColours.Items.Add("White Pearl Crystal Shine")
        Main.InfoModel.Text = "Toyota Innova '24"
        Main.InfoHorsepower.Text = "168 hp @ 3400 rpm"
        Main.InfoDisplacement.Text = "2755cc"
        Main.InfoPowertrain.Text = "FF"
    End Sub

    Private Sub optVIOS_CheckedChanged(sender As Object, e As EventArgs) Handles optVIOS.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota VIOS '24"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Black")
        CheckoutNew.cbColours.Items.Add("Super Red")
        CheckoutNew.cbColours.Items.Add("Grayish Blue Metallic")
        Main.InfoModel.Text = "Toyota VIOS '24"
        Main.InfoHorsepower.Text = "99 hp @ 3400 rpm"
        Main.InfoDisplacement.Text = "1496cc"
        Main.InfoPowertrain.Text = "FF"
    End Sub

    Private Sub optPrius_CheckedChanged(sender As Object, e As EventArgs) Handles optPrius.CheckedChanged
        CalculateCost()
        Main.Panelbottom.Height = 93
        Main.lblPrice.Text = price.Text
        Main.lbltax.Text = vat.Text
        Main.lblTotalCost.Text = txttotalcost.Text
        CheckoutNew.lblCar.Text = "Toyota Prius Prime '24"
        CheckoutNew.txtprice.Text = price.Text
        CheckoutNew.calpricevat.Text = txttotalcost.Text
        CheckoutNew.lblPrice.Text = price.Text
        CheckoutNew.lblVAT.Text = vat.Text
        CheckoutNew.lblTotal.Text = txttotalcost.Text
        CheckoutNew.cbColours.Items.Clear()
        CheckoutNew.cbColours.Items.Add("Reservoir Blue")
        CheckoutNew.cbColours.Items.Add("Guardian Grey")
        CheckoutNew.cbColours.Items.Add("Cutting Edge")
        CheckoutNew.cbColours.Items.Add("Midnight Black Metallic")
        CheckoutNew.cbColours.Items.Add("Wind Chill Pearl")
        CheckoutNew.cbColours.Items.Add("Supersonic Red")
        Main.InfoModel.Text = "Toyota Prius Prime '24"
        Main.InfoHorsepower.Text = "220 hp @ 6000 rpm"
        Main.InfoDisplacement.Text = "1100cc"
        Main.InfoPowertrain.Text = "FF"
    End Sub
End Class