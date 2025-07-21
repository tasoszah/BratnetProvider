using Newtonsoft.Json;

namespace BratnetProvider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "credentials.txt")).Split(Environment.NewLine);

            var credentials = new BratnetProviderCredentials(username: c[0], password: c[1]);

            var json =
                """
                                  {
                    "invoice": [
                      {
                        "tidNsp": "99000007",
                		"isUnsigned": false,
                		"issuer": {
                          "vatNumber": "113223052",
                          "country": "GR",
                          "branch": 0
                        },
                        "counterpart": {
                          "vatNumber": "802011000",
                          "country": "GR",
                          "branch": 0,
                          "address": {
                            "postalCode": "26441",
                            "city": "ΠΑΤΡΑ"
                          }
                        },
                        "invoiceHeader": {
                          "series": "ΤΔΑ",
                          "aa": "ΤΔΑ22",
                          "issueDate": "28-08-2025",
                          "invoiceType": "1.1",
                          "currency": "EUR" 
                        },
                        "paymentMethods": {
                          "paymentMethodDetails": [
                            {
                              "type": 1,
                              "amount": 50.0
                            }
                          ]
                        },
                        "invoiceDetails": [
                          {
                            "name": "ΕΜΠΟΡΕΥΜΑ 13%",
                            "code": "000003",
                            "lineNumber": 1,
                            "quantity": 10,
                            "measurementUnit": 1,
                            "netValueBeforeDiscount": 100,
                            "netValue": 100,
                            "vatAmount": 13,
                            "vatCategory": 2,
                            "incomeClassification": [
                              {
                                "classificationType": "E3_561_001",
                                "classificationCategory": "category1_1",
                                "amount": 100,
                                "id": 1
                              }
                            ],
                            "price": 10.0,
                            "measurementUnitName": "ΤΕΜ",
                            "vatPercent": 13,
                            "priceIncludeVAT": 0
                          },
                          {
                            "name": "ΕΜΠΟΡΕΥΜΑ 24%",
                            "code": "000004",
                            "lineNumber": 2,
                            "quantity": 10,
                            "measurementUnit": 1,
                            "netValueBeforeDiscount": 100.0,
                            "netValue": 100.0,
                            "vatAmount": 24,
                            "vatCategory": 1,
                            "incomeClassification": [
                              {
                                "classificationType": "E3_561_001",
                                "classificationCategory": "category1_1",
                                "amount": 100.0,
                                "id": 1
                              }
                            ],
                            "price": 10.0,
                            "measurementUnitName": "ΤΕΜ",
                            "vatPercent": 24,
                            "priceIncludeVAT": 0
                          }
                        ],
                        "invoiceSummary": {
                          "totalNetValue": 200.0,
                          "totalVatAmount": 37.0,
                          "totalWithheldAmount": 0,
                          "totalFeesAmount": 0,
                          "totalStampDutyAmount": 0,
                          "totalOtherTaxesAmount": 0,
                          "totalDeductionsAmount": 0,
                          "totalGrossValue": 237.0,
                          "totalPrintGrossValue": 237.0,
                          "incomeClassification": [
                            {
                              "classificationType": "E3_561_001",
                              "classificationCategory": "category1_1",
                              "amount": 200.0,
                              "id": 1
                            }
                          ]
                        },
                        "invoiceVatAnalysis": [
                          {
                            "vatCategory": 1,
                            "vatPercent": 24,
                            "netValuePerVat": 100.0,
                            "vatAmount": 24.0
                          },
                          {
                            "vatCategory": 2,
                            "vatPercent": 13,
                            "netValuePerVat": 100.0,
                            "vatAmount": 13.0
                          }
                        ],
                        "extra": {
                          "customerSendEmail": true,
                          "salerName": "ΚΑΛΑΝΤΖΗΣ ΔΗΜΗΤΡΙΟΣ ΓΕΩΡΓΙΟΣ",
                          "salerActivity": "ΥΠΗΡΕΣΙΕΣ ΕΝΟΙΚΙΑΣΗΣ ΕΩΣ ΕΠΤΑ (7) ΕΠΙΠΛΩΜΕΝΩΝ ΔΩΜΑΤΙΩΝ ΓΙΑ ΜΙΚΡΗ ΔΙΑΡΚΕΙΑ",
                          "salerStreetName": "ΧΙΛΙΑΔΟΥ ",
                          "salerAdditionalStreetName": "ΕΥΠΑΛΙΟ",
                          "salerTk": "33056",
                          "salerCity": "ΕΥΠΑΛΙΟ",
                          "salerPhone": "2610078000",
                          "salerEmail": "info@dsdc.gr",
                          "salerWebsite": "www.dsdc.gr",
                          "salerGemh": "000000000000",
                          "salerVat": "113223052",
                          "salerDoyCode": 4216,
                          "salerDoyName": "ΑΜΦΙΣΣΑΣ",
                          "customerName": "ΤΕΣΤ ΠΕΛΑΤΗΣ",
                          "customerActivity": "ΧΟΝΔΡΙΚΟ ΕΜΠΟΡΙΟ ΗΛΕΚΤΡΟΝΙΚΩΝ ΥΠΟΛΟΓΙΣΤΩΝ, ΠΕΡΙΦΕΡΕΙΑΚΟΥ ΕΞΟΠΛΙΣΜΟΥ ΥΠΟΛΟΓΙΣΤΩΝ ΚΑΙ ΛΟΓΙΣΜΙΚΟΥ",
                          "customerVat": "026883248",
                          "customerDoyCode": 4216,
                          "customerDoyName": "ΠΑΤΡΩΝ",
                          "customerStreetName": "ΠΑΝΕΠΙΣΤΗΜΙΟΥ 11",
                          "customerTk": "26441",
                          "customerCity": "ΠΑΤΡΑ",
                          "customerPhone": "2610007800",
                          "customerEmail": "support@dsdc.gr",
                          "shipmentName": "Οδικώς",
                          "loadingAddress": "Έδρα μας",
                          "destinationAddress": "Έδρα τους",
                          "paymentMethodName": "Cash",
                          "movePurpose": "Sale",
                          "invoiceTypeName": "SalesInvoice",
                          "salerTitle": "DSDC"
                        }
                      }
                    ]
                  }
                
                """;

            var model = JsonConvert.DeserializeObject<InvoicesRequestModel>(json);





            Console.WriteLine("Hello, World!");



        }
    }
}
