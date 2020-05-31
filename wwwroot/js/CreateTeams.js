var nbReservist = 0
                init()

                function init() {
                    HideAndDisable(3)
                    HideAndDisable(4)
                    HideAndDisable(5)
                    HideAndDisableRemoveButton()
                }

              
                function AddReservist() {
                    nbReservist++
                    var category = document.getElementById("cat")
                    var categorieStr = category.options[category.selectedIndex].text
                    if (categorieStr === "Nationale") {
                        ShowAndEnable(2 + nbReservist)
                        HideAndDisableAddButton()
                    } else {
                        ShowAndEnable(3 + nbReservist)
                        if (nbReservist === 2) {
                            HideAndDisableAddButton()
                        }
                    }
                    ShowAndEnableRemoveButton()
                }

                function RemoveReservist() {
                    var category = document.getElementById("cat")
                    var categorieStr = category.options[category.selectedIndex].text
                    if (categorieStr === "Nationale") {
                        HideAndDisable(2 + nbReservist)
                        ShowAndEnableAddButton()
                    } else {
                        HideAndDisable(3 + nbReservist)
                    }
                    nbReservist--
                    if (nbReservist <= 0) {
                        HideAndDisableRemoveButton()
                    }
                    ShowAndEnableAddButton()
                }

                function CategorySelected() {
                    nbReservist = 0
                    HideAndDisableRemoveButton()
                    ShowAndEnableAddButton()
                    var category = document.getElementById("cat")
                    var categorieStr = category.options[category.selectedIndex].text
                    console.log(categorieStr)
                    if (categorieStr === "Nationale") {
                        ShowAndEnable(0)
                        ShowAndEnable(1)
                        ShowAndEnable(2)
                        HideAndDisable(3)
                        HideAndDisable(4)
                        HideAndDisable(5)

                    } else {
                        ShowAndEnable(0)
                        ShowAndEnable(1)
                        ShowAndEnable(2)
                        ShowAndEnable(3)
                        HideAndDisable(4)
                        HideAndDisable(5)
                    }
                }

                function HideAndDisableAddButton() {
                    $(".ReservisteButtonAdd").eq(0).hide()
                    $(".ReservisteButtonAdd").eq(0).attr("disabled", true)
                }

                function HideAndDisable(i) {
                    $(".Player").eq(i).hide()
                    $(".Player").eq(i).find("input").attr("disabled", true)
                }

                function HideAndDisableRemoveButton() {
                    $(".ReservisteButtonRemove").eq(0).hide()
                    $(".ReservisteButtonRemove").eq(0).attr("disabled", true)
                }

                function ShowAndEnableRemoveButton() {
                    $(".ReservisteButtonRemove").eq(0).show()
                    $(".ReservisteButtonRemove").eq(0).attr("disabled", false)
                }

                function ShowAndEnableAddButton() {
                    $(".ReservisteButtonAdd").eq(0).show()
                    $(".ReservisteButtonAdd").eq(0).attr("disabled", false)
                }

                function ShowAndEnable(i) {
                    $(".Player").eq(i).show()
                    $(".Player").eq(i).find("input").attr("disabled", false)
                }

