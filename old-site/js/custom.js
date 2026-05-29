
        $(function () {
            $("#btnComment").click(function () {
                    
                
                var name = $.trim($("[id*=txtCommnetName]").val());
                var email = $.trim($("[id*=txtCommnetEmail]").val());
                var comment = $.trim($("[id*=txtCommentComment]").val());
                var ID = $.trim($("[id*=ctl00_ContentPlaceHolder1_comID]").val());
                var IP = $.trim($("[id*=ctl00_ContentPlaceHolder1_comIP]").val());


                if (name == "" || email == "" || comment == "") {
                    $("#formComment").valid();
                }
                       
                else {

                    var testEmail = /^[A-Z0-9._%+-]+@([A-Z0-9-]+\.)+[A-Z]{2,4}$/i;
                    if (testEmail.test(email)) {

                        $("[id*=commentResult]").html("<div class='alert alert-warning alert-dismissible' role='alert'><strong>Yorumunuz kaydediliyor. Lütfen bekleyiniz...</strong></div>");

                        $.ajax({
                            type: "POST",
                            url: "WebService.asmx/save",
                            data: "{ name: '" + name + "', email: '" + email + "', comment: '" + comment + "', ID: '" + ID + "',IP: '" + IP + "' }",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (r) {

                                $("[id*=txtCommnetName]").val("");
                                $("[id*=txtCommnetEmail]").val("");
                                $("[id*=txtCommentComment]").val("");
                                $("[id*=commentResult]").html("<div class='alert alert-success'><strong><i class='fa fa-thumbs-o-up'></i> Baþarýlý!</strong> Yorumunuz baþarýyla kaydedildi. Yönetici onayýndan sonra yayýnlanacaktýr..</div>");

                            },
                            error: function (r) {
                                $("[id*=commentResult]").html("<div class='alert alert-warning alert-dismissible' role='alert'><strong>Hata!</strong> Yorumunuz kaydedilemedi! Lütfen tekrar deneyiniz.</div>");

                            },
                            failure: function (r) {
                                $("[id*=commentResult]").html("<div class='alert alert-warning alert-dismissible' role='alert'><strong>Hata!</strong> Yorumunuz kaydedilemedi! Lütfen tekrar deneyiniz.</div>")
                            }
                        });
                    }
                    else {

                        $("#formComment").valid();


                    }


                }


                return false;
            });



            $("#btnCommentMakale").click(function () {


                var name = $.trim($("[id*=txtCommnetNameMakale]").val());
                var email = $.trim($("[id*=txtCommnetEmailMakale]").val());
                var comment = $.trim($("[id*=txtCommentCommentMakale]").val());
                var ID = $.trim($("[id*=ctl00_ContentPlaceHolder1_comIDMakale]").val());
                var IP = $.trim($("[id*=ctl00_ContentPlaceHolder1_comIPMakale]").val());


                if (name == "" || email == "" || comment == "") {
                    $("#formCommentMakale").valid();
                }

                else {

                    var testEmail = /^[A-Z0-9._%+-]+@([A-Z0-9-]+\.)+[A-Z]{2,4}$/i;
                    if (testEmail.test(email)) {

                        $("[id*=commentResultMakale]").html("<div class='alert alert-warning alert-dismissible' role='alert'><strong>Yorumunuz kaydediliyor. Lütfen bekleyiniz...</strong></div>");

                        $.ajax({
                            type: "POST",
                            url: "WebService.asmx/saveMakaleYorum",
                            data: "{ name: '" + name + "', email: '" + email + "', comment: '" + comment + "', ID: '" + ID + "',IP: '" + IP + "' }",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (r) {

                                $("[id*=txtCommnetNameMakale]").val("");
                                $("[id*=txtCommnetEmailMakale]").val("");
                                $("[id*=txtCommentCommentMakale]").val("");
                                $("[id*=commentResultMakale]").html("<div class='alert alert-success'><strong><i class='fa fa-thumbs-o-up'></i> Baþarýlý!</strong> Yorumunuz baþarýyla kaydedildi. Yönetici onayýndan sonra yayýnlanacaktýr..</div>");

                            },
                            error: function (r) {
                                $("[id*=commentResultMakale]").html("<div class='alert alert-warning alert-dismissible' role='alert'><strong>Hata!</strong> Yorumunuz kaydedilemedi! Lütfen tekrar deneyiniz.</div>");

                            },
                            failure: function (r) {
                                $("[id*=commentResultMakale]").html("<div class='alert alert-warning alert-dismissible' role='alert'><strong>Hata!</strong> Yorumunuz kaydedilemedi! Lütfen tekrar deneyiniz.</div>")
                            }
                        });
                    }
                    else {

                        $("#formCommentMakale").valid();


                    }


                }


                return false;
            });


            $("#btnSearch").click(function () {


                var aranacakKelime = $.trim($("[id*=searchText]").val());
                
                if (aranacakKelime == "") {
                    $("#searchForm").valid();
                }

                else {

                    location.href = "arama-sonuclari.aspx?" + aranacakKelime;

                }


                return false;
            });



            $("#btnSearchSayfa").click(function () {


                var aranacakKelime = $.trim($("[id*=searchTextSayfa]").val());

                if (aranacakKelime == "") {
                    $("#searchFormSayfa").valid();
                }

                else {

                    location.href = "arama-sonuclari.aspx?" + aranacakKelime;

                }


                return false;
            });














        });