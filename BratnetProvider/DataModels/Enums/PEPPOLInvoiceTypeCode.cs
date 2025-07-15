namespace BratnetProvider
{
    /// <summary>
    /// Provides enumeration over the PEPPOL invoice type codes
    /// </summary>
    /// <remarks>
    /// https://docs.peppol.eu/pracc/catalogue/1.0/codelist/UNCL1001/
    /// </remarks>
    public enum PEPPOLInvoiceTypeCode
    {
        /// <summary>
        /// Certificate of analysis (Code: 1)
        /// </summary>
        /// <remarks>
        /// Certificate providing the values of an analysis.
        /// </remarks>
        CertificateOfAnalysis,

        /// <summary>
        /// Certificate of conformity (Code: 2)
        /// </summary>
        /// <remarks>
        /// Certificate certifying the conformity to predefined definitions.
        /// </remarks>
        CertificateOfConformity,

        /// <summary>
        /// Certificate of quality (Code: 3)
        /// </summary>
        /// <remarks>
        /// Certificate certifying the quality of goods, services etc.
        /// </remarks>
        CertificateOfQuality,

        /// <summary>
        /// Test report (Code: 4)
        /// </summary>
        /// <remarks>
        /// Report providing the results of a test session.
        /// </remarks>
        TestReport,

        /// <summary>
        /// Product performance report (Code: 5)
        /// </summary>
        /// <remarks>
        /// Report specifying the performance values of products.
        /// </remarks>
        ProductPerformanceReport,

        /// <summary>
        /// Product specification report (Code: 6)
        /// </summary>
        /// <remarks>
        /// Report providing specification values of products.
        /// </remarks>
        ProductSpecificationReport,

        /// <summary>
        /// Process data report (Code: 7)
        /// </summary>
        /// <remarks>
        /// Reports on events during production process.
        /// </remarks>
        ProcessDataReport,

        /// <summary>
        /// First sample test report (Code: 8)
        /// </summary>
        /// <remarks>
        /// Document/message describes the test report of the first sample.
        /// </remarks>
        FirstSampleTestReport,

        /// <summary>
        /// Price/sales catalogue (Code: 9)
        /// </summary>
        /// <remarks>
        /// A document/message to enable the transmission of information regarding pricing and catalogue details for goods and services offered by a seller to a buyer.
        /// </remarks>
        PricesalesCatalogue,

        /// <summary>
        /// Party information (Code: 10)
        /// </summary>
        /// <remarks>
        /// Document/message providing basic data concerning a party.
        /// </remarks>
        PartyInformation,

        /// <summary>
        /// Federal label approval (Code: 11)
        /// </summary>
        /// <remarks>
        /// A pre-approved document relating to federal label approval requirements.
        /// </remarks>
        FederalLabelApproval,

        /// <summary>
        /// Mill certificate (Code: 12)
        /// </summary>
        /// <remarks>
        /// Certificate certifying a specific quality of agricultural products.
        /// </remarks>
        MillCertificate,

        /// <summary>
        /// Post receipt (Code: 13)
        /// </summary>
        /// <remarks>
        /// Document/message which evidences the transport of goods by post (e.g. mail, parcel, etc.).
        /// </remarks>
        PostReceipt,

        /// <summary>
        /// Weight certificate (Code: 14)
        /// </summary>
        /// <remarks>
        /// Certificate certifying the weight of goods.
        /// </remarks>
        WeightCertificate,

        /// <summary>
        /// Weight list (Code: 15)
        /// </summary>
        /// <remarks>
        /// Document/message specifying the weight of goods.
        /// </remarks>
        WeightList,

        /// <summary>
        /// Certificate (Code: 16)
        /// </summary>
        /// <remarks>
        /// Document by means of which the documentary credit applicant specifies the conditions for the certificate and by whom the certificate is to be issued.
        /// </remarks>
        Certificate,

        /// <summary>
        /// Combined certificate of value and origin (Code: 17)
        /// </summary>
        /// <remarks>
        /// Document identifying goods in which the issuing authority expressly certifies that the goods originate in a specific country or part of, or group of countries. It also states the price and/or cost of the goods with the purpose of determining the customs origin.
        /// </remarks>
        CombinedCertificateOfValueAndOrigin,

        /// <summary>
        /// Movement certificate A.TR.1 (Code: 18)
        /// </summary>
        /// <remarks>
        /// Specific form of transit declaration issued by the exporter (movement certificate).
        /// </remarks>
        MovementCertificateATR1,

        /// <summary>
        /// Certificate of quantity (Code: 19)
        /// </summary>
        /// <remarks>
        /// Certificate certifying the quantity of goods, services etc.
        /// </remarks>
        CertificateOfQuantity,

        /// <summary>
        /// Quality data message (Code: 20)
        /// </summary>
        /// <remarks>
        /// Usage of QALITY-message.
        /// </remarks>
        QualityDataMessage,

        /// <summary>
        /// Query (Code: 21)
        /// </summary>
        /// <remarks>
        /// Request information based on defined criteria.
        /// </remarks>
        Query,

        /// <summary>
        /// Response to query (Code: 22)
        /// </summary>
        /// <remarks>
        /// Document/message returned as an answer to a question.
        /// </remarks>
        ResponseToQuery,

        /// <summary>
        /// Status information (Code: 23)
        /// </summary>
        /// <remarks>
        /// Information regarding the status of a related message.
        /// </remarks>
        StatusInformation,

        /// <summary>
        /// Restow (Code: 24)
        /// </summary>
        /// <remarks>
        /// Message/document identifying containers that have been unloaded and then reloaded onto the same means of transport.
        /// </remarks>
        Restow,

        /// <summary>
        /// Container discharge list (Code: 25)
        /// </summary>
        /// <remarks>
        /// Message/document itemising containers to be discharged from vessel.
        /// </remarks>
        ContainerDischargeList,

        /// <summary>
        /// Corporate superannuation contributions advice (Code: 26)
        /// </summary>
        /// <remarks>
        /// Document/message providing contributions advice used for corporate superannuation schemes.
        /// </remarks>
        CorporateSuperannuationContributionsAdvice,

        /// <summary>
        /// Industry superannuation contributions advice (Code: 27)
        /// </summary>
        /// <remarks>
        /// Document/message providing contributions advice used for superannuation schemes which are industry wide.
        /// </remarks>
        IndustrySuperannuationContributionsAdvice,

        /// <summary>
        /// Corporate superannuation member maintenance message (Code: 28)
        /// </summary>
        /// <remarks>
        /// Member maintenance message used for corporate superannuation schemes.
        /// </remarks>
        CorporateSuperannuationMemberMaintenanceMessage,

        /// <summary>
        /// Industry superannuation member maintenance message (Code: 29)
        /// </summary>
        /// <remarks>
        /// Member maintenance message used for industry wide superannuation schemes.
        /// </remarks>
        IndustrySuperannuationMemberMaintenanceMessage,

        /// <summary>
        /// Life insurance payroll deductions advice (Code: 30)
        /// </summary>
        /// <remarks>
        /// Payroll deductions advice used in the life insurance industry.
        /// </remarks>
        LifeInsurancePayrollDeductionsAdvice,

        /// <summary>
        /// Underbond request (Code: 31)
        /// </summary>
        /// <remarks>
        /// A Message/document requesting to move cargo from one Customs control point to another.
        /// </remarks>
        UnderbondRequest,

        /// <summary>
        /// Underbond approval (Code: 32)
        /// </summary>
        /// <remarks>
        /// A message/document issuing Customs approval to move cargo from one Customs control point to another.
        /// </remarks>
        UnderbondApproval,

        /// <summary>
        /// Certificate of sealing of export meat lockers (Code: 33)
        /// </summary>
        /// <remarks>
        /// Document / message issued by the authority in the exporting country evidencing the sealing of export meat lockers.
        /// </remarks>
        CertificateOfSealingOfExportMeatLockers,

        /// <summary>
        /// Cargo status (Code: 34)
        /// </summary>
        /// <remarks>
        /// Message identifying the status of cargo.
        /// </remarks>
        CargoStatus,

        /// <summary>
        /// Inventory report (Code: 35)
        /// </summary>
        /// <remarks>
        /// A message specifying information relating to held inventories.
        /// </remarks>
        InventoryReport,

        /// <summary>
        /// Identity card (Code: 36)
        /// </summary>
        /// <remarks>
        /// Official document to identify a person.
        /// </remarks>
        IdentityCard,

        /// <summary>
        /// Response to a trade statistics message (Code: 37)
        /// </summary>
        /// <remarks>
        /// Document/message in which the competent national authorities provide a declarant with an acceptance or a rejection about a received declaration for European statistical purposes.
        /// </remarks>
        ResponseToATradeStatisticsMessage,

        /// <summary>
        /// Vaccination certificate (Code: 38)
        /// </summary>
        /// <remarks>
        /// Official document proving immunisation against certain diseases.
        /// </remarks>
        VaccinationCertificate,

        /// <summary>
        /// Passport (Code: 39)
        /// </summary>
        /// <remarks>
        /// An official document giving permission to travel in foreign countries.
        /// </remarks>
        Passport,

        /// <summary>
        /// Driving licence (national) (Code: 40)
        /// </summary>
        /// <remarks>
        /// An official document giving permission to drive a car in a given country.
        /// </remarks>
        DrivingLicenceNational,

        /// <summary>
        /// Driving licence (international) (Code: 41)
        /// </summary>
        /// <remarks>
        /// An official document giving a native of one country permission to drive a vehicle in certain other countries.
        /// </remarks>
        DrivingLicenceInternational,

        /// <summary>
        /// Free pass (Code: 42)
        /// </summary>
        /// <remarks>
        /// A document giving free access to a service.
        /// </remarks>
        FreePass,

        /// <summary>
        /// Season ticket (Code: 43)
        /// </summary>
        /// <remarks>
        /// A document giving access to a service for a determined period of time.
        /// </remarks>
        SeasonTicket,

        /// <summary>
        /// Transport status report (Code: 44)
        /// </summary>
        /// <remarks>
        /// (1125) A message to report the transport status and/or change in the transport status (i.e. event) between agreed parties.
        /// </remarks>
        TransportStatusReport,

        /// <summary>
        /// Transport status request (Code: 45)
        /// </summary>
        /// <remarks>
        /// (1127) A message to request a transport status report (e.g. through the national multimodal status report message IFSTA).
        /// </remarks>
        TransportStatusRequest,

        /// <summary>
        /// Banking status (Code: 46)
        /// </summary>
        /// <remarks>
        /// A banking status document and/or message.
        /// </remarks>
        BankingStatus,

        /// <summary>
        /// Extra-Community trade statistical declaration (Code: 47)
        /// </summary>
        /// <remarks>
        /// Document/message in which a declarant provides information about extra-Community trade of goods required by the body responsible for the collection of trade statistics. Trade by a country in the European Union with a country outside the European Union.
        /// </remarks>
        ExtraCommunityTradeStatisticalDeclaration,

        /// <summary>
        /// Written instructions in conformance with ADR article number (Code: 48)
        /// </summary>
        /// <remarks>
        /// 10385 Written instructions relating to dangerous goods and defined in the European Agreement of Dangerous Transport by Road known as ADR (Accord europeen relatif au transport international des marchandises Dangereuses par Route).
        /// </remarks>
        WrittenInstructionsInConformanceWithADRArticleNumber,

        /// <summary>
        /// Damage certification (Code: 49)
        /// </summary>
        /// <remarks>
        /// Official certification that damages to the goods to be transported have been discovered.
        /// </remarks>
        DamageCertification,

        /// <summary>
        /// Validated priced tender (Code: 50)
        /// </summary>
        /// <remarks>
        /// A validated priced tender.
        /// </remarks>
        ValidatedPricedTender,

        /// <summary>
        /// Price/sales catalogue response (Code: 51)
        /// </summary>
        /// <remarks>
        /// A document providing a response to a previously sent price/sales catalogue.
        /// </remarks>
        PricesalesCatalogueResponse,

        /// <summary>
        /// Price negotiation result (Code: 52)
        /// </summary>
        /// <remarks>
        /// A document providing the result of price negotiations.
        /// </remarks>
        PriceNegotiationResult,

        /// <summary>
        /// Safety and hazard data sheet (Code: 53)
        /// </summary>
        /// <remarks>
        /// Document or message to supply advice on a dangerous or hazardous material to industrial customers so as to enable them to take measures to protect their employees and the environment from any potential harmful effects from these material.
        /// </remarks>
        SafetyAndHazardDataSheet,

        /// <summary>
        /// Legal statement of an account (Code: 54)
        /// </summary>
        /// <remarks>
        /// A statement of an account containing the booked items as in the ledger of the account servicing financial institution.
        /// </remarks>
        LegalStatementOfAnAccount,

        /// <summary>
        /// Listing statement of an account (Code: 55)
        /// </summary>
        /// <remarks>
        /// A statement from the account servicing financial institution containing items pending to be booked.
        /// </remarks>
        ListingStatementOfAnAccount,

        /// <summary>
        /// Closing statement of an account (Code: 56)
        /// </summary>
        /// <remarks>
        /// Last statement of a period containing the interest calculation and the final balance of the last entry date.
        /// </remarks>
        ClosingStatementOfAnAccount,

        /// <summary>
        /// Transport equipment on-hire report (Code: 57)
        /// </summary>
        /// <remarks>
        /// Report on the movement of containers or other items of transport equipment to record physical movement activity and establish the beginning of a rental period.
        /// </remarks>
        TransportEquipmentOnHireReport,

        /// <summary>
        /// Transport equipment off-hire report (Code: 58)
        /// </summary>
        /// <remarks>
        /// Report on the movement of containers or other items of transport equipment to record physical movement activity and establish the end of a rental period.
        /// </remarks>
        TransportEquipmentOffHireReport,

        /// <summary>
        /// Treatment - nil outturn (Code: 59)
        /// </summary>
        /// <remarks>
        /// No shortage, surplus or damaged outturn resulting from container vessel unpacking.
        /// </remarks>
        TreatmentNilOutturn,

        /// <summary>
        /// Treatment - time-up underbond (Code: 60)
        /// </summary>
        /// <remarks>
        /// Movement type indicator: goods are moved under customs control for warehousing due to being time-up.
        /// </remarks>
        TreatmentTimeUpUnderbond,

        /// <summary>
        /// Treatment - underbond by sea (Code: 61)
        /// </summary>
        /// <remarks>
        /// Movement type indicator: goods are to move by sea under customs control to a customs office where formalities will be completed.
        /// </remarks>
        TreatmentUnderbondBySea,

        /// <summary>
        /// Treatment - personal effect (Code: 62)
        /// </summary>
        /// <remarks>
        /// Cargo consists of personal effects.
        /// </remarks>
        TreatmentPersonalEffect,

        /// <summary>
        /// Treatment - timber (Code: 63)
        /// </summary>
        /// <remarks>
        /// Cargo consists of timber.
        /// </remarks>
        TreatmentTimber,

        /// <summary>
        /// Preliminary credit assessment (Code: 64)
        /// </summary>
        /// <remarks>
        /// Document/message issued either by a factor to indicate his preliminary credit assessment on a buyer, or by a seller to request a factor's preliminary credit assessment on a buyer.
        /// </remarks>
        PreliminaryCreditAssessment,

        /// <summary>
        /// Credit cover (Code: 65)
        /// </summary>
        /// <remarks>
        /// Document/message issued either by a factor to give a credit cover on a buyer, or by a seller to request a factor's credit cover.
        /// </remarks>
        CreditCover,

        /// <summary>
        /// Current account (Code: 66)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a factor to indicate the money movements of a seller's or another factor's account with him.
        /// </remarks>
        CurrentAccount,

        /// <summary>
        /// Commercial dispute (Code: 67)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a party (usually the buyer) to indicate that one or more invoices or one or more credit notes are disputed for payment.
        /// </remarks>
        CommercialDispute,

        /// <summary>
        /// Chargeback (Code: 68)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a factor to a seller or to another factor to indicate that the rest of the amounts of one or more invoices uncollectable from buyers are charged back to clear the invoice(s) off the ledger.
        /// </remarks>
        Chargeback,

        /// <summary>
        /// Reassignment (Code: 69)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a factor to a seller or to another factor to reassign an invoice or credit note previously assigned to him.
        /// </remarks>
        Reassignment,

        /// <summary>
        /// Collateral account (Code: 70)
        /// </summary>
        /// <remarks>
        /// Document message issued by a factor to indicate the movements of invoices, credit notes and payments of a seller's account.
        /// </remarks>
        CollateralAccount,

        /// <summary>
        /// Request for payment (Code: 71)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a creditor to a debtor to request payment of one or more invoices past due.
        /// </remarks>
        RequestForPayment,

        /// <summary>
        /// Unship permit (Code: 72)
        /// </summary>
        /// <remarks>
        /// A message or document issuing permission to unship cargo.
        /// </remarks>
        UnshipPermit,

        /// <summary>
        /// Statistical definitions (Code: 73)
        /// </summary>
        /// <remarks>
        /// Transmission of one or more statistical definitions.
        /// </remarks>
        StatisticalDefinitions,

        /// <summary>
        /// Statistical data (Code: 74)
        /// </summary>
        /// <remarks>
        /// Transmission of one or more items of data or data sets.
        /// </remarks>
        StatisticalData,

        /// <summary>
        /// Request for statistical data (Code: 75)
        /// </summary>
        /// <remarks>
        /// Request for one or more items or data sets of statistical data.
        /// </remarks>
        RequestForStatisticalData,

        /// <summary>
        /// Call-off delivery (Code: 76)
        /// </summary>
        /// <remarks>
        /// Document/message to provide split quantities and delivery dates referring to a previous delivery instruction.
        /// </remarks>
        CallOffDelivery,

        /// <summary>
        /// Consignment status report (Code: 77)
        /// </summary>
        /// <remarks>
        /// Message covers information about the consignment status.
        /// </remarks>
        ConsignmentStatusReport,

        /// <summary>
        /// Inventory movement advice (Code: 78)
        /// </summary>
        /// <remarks>
        /// Advice of inventory movements.
        /// </remarks>
        InventoryMovementAdvice,

        /// <summary>
        /// Inventory status advice (Code: 79)
        /// </summary>
        /// <remarks>
        /// Advice of stock on hand.
        /// </remarks>
        InventoryStatusAdvice,

        /// <summary>
        /// Debit note related to goods or services (Code: 80)
        /// </summary>
        /// <remarks>
        /// Debit information related to a transaction for goods or services to the relevant party.
        /// </remarks>
        DebitNoteRelatedToGoodsOrServices,

        /// <summary>
        /// Credit note related to goods or services (Code: 81)
        /// </summary>
        /// <remarks>
        /// Document message used to provide credit information related to a transaction for goods or services to the relevant party.
        /// </remarks>
        CreditNoteRelatedToGoodsOrServices,

        /// <summary>
        /// Metered services invoice (Code: 82)
        /// </summary>
        /// <remarks>
        /// Document/message claiming payment for the supply of metered services (e.g., gas, electricity, etc.) supplied to a fixed meter whose consumption is measured over a period of time.
        /// </remarks>
        MeteredServicesInvoice,

        /// <summary>
        /// Credit note related to financial adjustments (Code: 83)
        /// </summary>
        /// <remarks>
        /// Document message for providing credit information related to financial adjustments to the relevant party, e.g., bonuses.
        /// </remarks>
        CreditNoteRelatedToFinancialAdjustments,

        /// <summary>
        /// Debit note related to financial adjustments (Code: 84)
        /// </summary>
        /// <remarks>
        /// Document/message for providing debit information related to financial adjustments to the relevant party.
        /// </remarks>
        DebitNoteRelatedToFinancialAdjustments,

        /// <summary>
        /// Customs manifest (Code: 85)
        /// </summary>
        /// <remarks>
        /// Message/document identifying a customs manifest. The document itemises a list of cargo prepared by shipping companies from bills of landing and presented to customs for formal report of cargo.
        /// </remarks>
        CustomsManifest,

        /// <summary>
        /// Vessel unpack report (Code: 86)
        /// </summary>
        /// <remarks>
        /// A document code to indicate that the message being transmitted identifies all short and surplus cargoes off-loaded from a vessel at a specified discharging port.
        /// </remarks>
        VesselUnpackReport,

        /// <summary>
        /// General cargo summary manifest report (Code: 87)
        /// </summary>
        /// <remarks>
        /// A document code to indicate that the message being transmitted is summary manifest information for general cargo.
        /// </remarks>
        GeneralCargoSummaryManifestReport,

        /// <summary>
        /// Consignment unpack report (Code: 88)
        /// </summary>
        /// <remarks>
        /// A document code to indicate that the message being transmitted is a consignment unpack report only.
        /// </remarks>
        ConsignmentUnpackReport,

        /// <summary>
        /// Meat and meat by-products sanitary certificate (Code: 89)
        /// </summary>
        /// <remarks>
        /// Document or message issued by the competent authority in the exporting country evidencing that meat or meat by- products comply with the requirements set by the importing country.
        /// </remarks>
        MeatAndMeatByProductsSanitaryCertificate,

        /// <summary>
        /// Meat food products sanitary certificate (Code: 90)
        /// </summary>
        /// <remarks>
        /// Document or message issued by the competent authority in the exporting country evidencing that meat food products comply with the requirements set by the importing country.
        /// </remarks>
        MeatFoodProductsSanitaryCertificate,

        /// <summary>
        /// Poultry sanitary certificate (Code: 91)
        /// </summary>
        /// <remarks>
        /// Document or message issued by the competent authority in the exporting country evidencing that poultry products comply with the requirements set by the importing country.
        /// </remarks>
        PoultrySanitaryCertificate,

        /// <summary>
        /// Horsemeat sanitary certificate (Code: 92)
        /// </summary>
        /// <remarks>
        /// Document or message issued by the competent authority in the exporting country evidencing that horsemeat products comply with the requirements set by the importing country.
        /// </remarks>
        HorsemeatSanitaryCertificate,

        /// <summary>
        /// Casing sanitary certificate (Code: 93)
        /// </summary>
        /// <remarks>
        /// Document or message issued by the competent authority in the exporting country evidencing that casing products comply with the requirements set by the importing country.
        /// </remarks>
        CasingSanitaryCertificate,

        /// <summary>
        /// Pharmaceutical sanitary certificate (Code: 94)
        /// </summary>
        /// <remarks>
        /// Document or message issued by the competent authority in the exporting country evidencing that pharmaceutical products comply with the requirements set by the importing country.
        /// </remarks>
        PharmaceuticalSanitaryCertificate,

        /// <summary>
        /// Inedible sanitary certificate (Code: 95)
        /// </summary>
        /// <remarks>
        /// Document or message issued by the competent authority in the exporting country evidencing that inedible products comply with the requirements set by the importing country.
        /// </remarks>
        InedibleSanitaryCertificate,

        /// <summary>
        /// Impending arrival (Code: 96)
        /// </summary>
        /// <remarks>
        /// Notification of impending arrival details for vessel.
        /// </remarks>
        ImpendingArrival,

        /// <summary>
        /// Means of transport advice (Code: 97)
        /// </summary>
        /// <remarks>
        /// Message reporting the means of transport used to carry goods or cargo.
        /// </remarks>
        MeansOfTransportAdvice,

        /// <summary>
        /// Arrival information (Code: 98)
        /// </summary>
        /// <remarks>
        /// Message reporting the arrival details of goods or cargo.
        /// </remarks>
        ArrivalInformation,

        /// <summary>
        /// Cargo release notification (Code: 99)
        /// </summary>
        /// <remarks>
        /// Message/document sent by the cargo handler indicating that the cargo has moved from a Customs controlled premise.
        /// </remarks>
        CargoReleaseNotification,

        /// <summary>
        /// Excise certificate (Code: 100)
        /// </summary>
        /// <remarks>
        /// Certificate asserting that the goods have been submitted to the excise authorities before departure from the exporting country or before delivery in case of import traffic.
        /// </remarks>
        ExciseCertificate,

        /// <summary>
        /// Registration document (Code: 101)
        /// </summary>
        /// <remarks>
        /// An official document providing registration details.
        /// </remarks>
        RegistrationDocument,

        /// <summary>
        /// Tax notification (Code: 102)
        /// </summary>
        /// <remarks>
        /// Used to specify that the message is a tax notification.
        /// </remarks>
        TaxNotification,

        /// <summary>
        /// Transport equipment direct interchange report (Code: 103)
        /// </summary>
        /// <remarks>
        /// Report on the movement of containers or other items of transport equipment being exchanged, establishing relevant rental periods.
        /// </remarks>
        TransportEquipmentDirectInterchangeReport,

        /// <summary>
        /// Transport equipment impending arrival advice (Code: 104)
        /// </summary>
        /// <remarks>
        /// Advice that containers or other items of transport equipment may be expected to be delivered to a certain location.
        /// </remarks>
        TransportEquipmentImpendingArrivalAdvice,

        /// <summary>
        /// Purchase order (Code: 105)
        /// </summary>
        /// <remarks>
        /// Document/message issued within an enterprise to initiate the purchase of articles, materials or services required for the production or manufacture of goods to be offered for sale or otherwise supplied to customers.
        /// </remarks>
        PurchaseOrder,

        /// <summary>
        /// Transport equipment damage report (Code: 106)
        /// </summary>
        /// <remarks>
        /// Report of damaged items of transport equipment that have been returned.
        /// </remarks>
        TransportEquipmentDamageReport,

        /// <summary>
        /// Transport equipment maintenance and repair work estimate (Code: 107)
        /// </summary>
        /// <remarks>
        /// Advice providing estimates of transport equipment maintenance and repair costs.
        /// </remarks>
        AdviceForTransportEquipmentMaintenanceAndRepairWorkEstimate,

        /// <summary>
        /// Transport equipment empty release instruction (Code: 108)
        /// </summary>
        /// <remarks>
        /// Instruction to release an item of empty transport equipment to a specified party or parties.
        /// </remarks>
        TransportEquipmentEmptyReleaseInstruction,

        /// <summary>
        /// Transport movement gate in report (Code: 109)
        /// </summary>
        /// <remarks>
        /// Report on the inward movement of cargo, containers or other items of transport equipment which have been delivered to a facility by an inland carrier.
        /// </remarks>
        TransportMovementGateInReport,

        /// <summary>
        /// Manufacturing instructions (Code: 110)
        /// </summary>
        /// <remarks>
        /// Document/message issued within an enterprise to initiate the manufacture of goods to be offered for sale.
        /// </remarks>
        ManufacturingInstructions,

        /// <summary>
        /// Transport movement gate out report (Code: 111)
        /// </summary>
        /// <remarks>
        /// Report on the outward movement of cargo, containers or other items of transport equipment (either full or empty) which have been picked up by an inland carrier.
        /// </remarks>
        TransportMovementGateOutReport,

        /// <summary>
        /// Transport equipment unpacking instruction (Code: 112)
        /// </summary>
        /// <remarks>
        /// Instruction to unpack specified cargo from specified containers or other items of transport equipment.
        /// </remarks>
        TransportEquipmentUnpackingInstruction,

        /// <summary>
        /// Transport equipment unpacking report (Code: 113)
        /// </summary>
        /// <remarks>
        /// Report on the completion of unpacking specified containers or other items of transport equipment.
        /// </remarks>
        TransportEquipmentUnpackingReport,

        /// <summary>
        /// Transport equipment pick-up availability request (Code: 114)
        /// </summary>
        /// <remarks>
        /// Request for confirmation that an item of transport equipment will be available for collection.
        /// </remarks>
        TransportEquipmentPickUpAvailabilityRequest,

        /// <summary>
        /// Transport equipment pick-up availability confirmation (Code: 115)
        /// </summary>
        /// <remarks>
        /// Confirmation that an item of transport equipment is available for collection.
        /// </remarks>
        TransportEquipmentPickUpAvailabilityConfirmation,

        /// <summary>
        /// Transport equipment pick-up report (Code: 116)
        /// </summary>
        /// <remarks>
        /// Report that an item of transport equipment has been collected.
        /// </remarks>
        TransportEquipmentPickUpReport,

        /// <summary>
        /// Transport equipment shift report (Code: 117)
        /// </summary>
        /// <remarks>
        /// Report on the movement of containers or other items of transport within a facility.
        /// </remarks>
        TransportEquipmentShiftReport,

        /// <summary>
        /// Transport discharge instruction (Code: 118)
        /// </summary>
        /// <remarks>
        /// Instruction to unload specified cargo, containers or transport equipment from a means of transport.
        /// </remarks>
        TransportDischargeInstruction,

        /// <summary>
        /// Transport discharge report (Code: 119)
        /// </summary>
        /// <remarks>
        /// Report on cargo, containers or transport equipment unloaded from a particular means of transport.
        /// </remarks>
        TransportDischargeReport,

        /// <summary>
        /// Stores requisition (Code: 120)
        /// </summary>
        /// <remarks>
        /// Document/message issued within an enterprise ordering the taking out of stock of goods.
        /// </remarks>
        StoresRequisition,

        /// <summary>
        /// Transport loading instruction (Code: 121)
        /// </summary>
        /// <remarks>
        /// Instruction to load cargo, containers or transport equipment onto a means of transport.
        /// </remarks>
        TransportLoadingInstruction,

        /// <summary>
        /// Transport loading report (Code: 122)
        /// </summary>
        /// <remarks>
        /// Report on completion of loading cargo, containers or other transport equipment onto a means of transport.
        /// </remarks>
        TransportLoadingReport,

        /// <summary>
        /// Transport equipment maintenance and repair work (Code: 123)
        /// </summary>
        /// <remarks>
        /// authorisation Authorisation to have transport equipment repaired or to have maintenance performed.
        /// </remarks>
        TransportEquipmentMaintenanceAndRepairWork,

        /// <summary>
        /// Transport departure report (Code: 124)
        /// </summary>
        /// <remarks>
        /// Report of the departure of a means of transport from a particular facility.
        /// </remarks>
        TransportDepartureReport,

        /// <summary>
        /// Transport empty equipment advice (Code: 125)
        /// </summary>
        /// <remarks>
        /// Advice that an item or items of empty transport equipment are available for return.
        /// </remarks>
        TransportEmptyEquipmentAdvice,

        /// <summary>
        /// Transport equipment acceptance order (Code: 126)
        /// </summary>
        /// <remarks>
        /// Order to accept items of transport equipment which are to be delivered by an inland carrier (rail, road or barge) to a specified facility.
        /// </remarks>
        TransportEquipmentAcceptanceOrder,

        /// <summary>
        /// Transport equipment special service instruction (Code: 127)
        /// </summary>
        /// <remarks>
        /// Instruction to perform a specified service or services on an item or items of transport equipment.
        /// </remarks>
        TransportEquipmentSpecialServiceInstruction,

        /// <summary>
        /// Transport equipment stock report (Code: 128)
        /// </summary>
        /// <remarks>
        /// Report on the number of items of transport equipment stored at one or more locations.
        /// </remarks>
        TransportEquipmentStockReport,

        /// <summary>
        /// Transport cargo release order (Code: 129)
        /// </summary>
        /// <remarks>
        /// Order to release cargo or items of transport equipment to a specified party.
        /// </remarks>
        TransportCargoReleaseOrder,

        /// <summary>
        /// Invoicing data sheet (Code: 130)
        /// </summary>
        /// <remarks>
        /// Document/message issued within an enterprise containing data about goods sold, to be used as the basis for the preparation of an invoice.
        /// </remarks>
        InvoicingDataSheet,

        /// <summary>
        /// Transport equipment packing instruction (Code: 131)
        /// </summary>
        /// <remarks>
        /// Instruction to pack cargo into a container or other item of transport equipment.
        /// </remarks>
        TransportEquipmentPackingInstruction,

        /// <summary>
        /// Customs clearance notice (Code: 132)
        /// </summary>
        /// <remarks>
        /// Notification of customs clearance of cargo or items of transport equipment.
        /// </remarks>
        CustomsClearanceNotice,

        /// <summary>
        /// Customs documents expiration notice (Code: 133)
        /// </summary>
        /// <remarks>
        /// Notice specifying expiration of Customs documents relating to cargo or items of transport equipment.
        /// </remarks>
        CustomsDocumentsExpirationNotice,

        /// <summary>
        /// Transport equipment on-hire request (Code: 134)
        /// </summary>
        /// <remarks>
        /// Request for transport equipment to be made available for hire.
        /// </remarks>
        TransportEquipmentOnHireRequest,

        /// <summary>
        /// Transport equipment on-hire order (Code: 135)
        /// </summary>
        /// <remarks>
        /// Order to release empty items of transport equipment for on-hire to a lessee, and authorising collection by or on behalf of a specified party.
        /// </remarks>
        TransportEquipmentOnHireOrder,

        /// <summary>
        /// Transport equipment off-hire request (Code: 136)
        /// </summary>
        /// <remarks>
        /// Request to terminate the lease on an item of transport equipment at a specified time.
        /// </remarks>
        TransportEquipmentOffHireRequest,

        /// <summary>
        /// Transport equipment survey order (Code: 137)
        /// </summary>
        /// <remarks>
        /// Order to perform a survey on specified items of transport equipment.
        /// </remarks>
        TransportEquipmentSurveyOrder,

        /// <summary>
        /// Transport equipment survey order response (Code: 138)
        /// </summary>
        /// <remarks>
        /// Response to an order to conduct a survey of transport equipment.
        /// </remarks>
        TransportEquipmentSurveyOrderResponse,

        /// <summary>
        /// Transport equipment survey report (Code: 139)
        /// </summary>
        /// <remarks>
        /// Survey report of specified items of transport equipment.
        /// </remarks>
        TransportEquipmentSurveyReport,

        /// <summary>
        /// Packing instructions (Code: 140)
        /// </summary>
        /// <remarks>
        /// Document/message within an enterprise giving instructions on how goods are to be packed.
        /// </remarks>
        PackingInstructions,

        /// <summary>
        /// Advising items to be booked to a financial account (Code: 141)
        /// </summary>
        /// <remarks>
        /// A document and/or message advising of items which have to be booked to a financial account.
        /// </remarks>
        AdvisingItemsToBeBookedToAFinancialAccount,

        /// <summary>
        /// Transport equipment maintenance and repair work estimate (Code: 142)
        /// </summary>
        /// <remarks>
        /// Order to draw up an estimate of the costs of maintenance or repair of transport equipment.
        /// </remarks>
        OrderForTransportEquipmentMaintenanceAndRepairWorkEstimate,

        /// <summary>
        /// Transport equipment maintenance and repair notice (Code: 143)
        /// </summary>
        /// <remarks>
        /// Report of transport equipment which has been repaired or has had maintenance performed.
        /// </remarks>
        TransportEquipmentMaintenanceAndRepairNotice,

        /// <summary>
        /// Empty container disposition order (Code: 144)
        /// </summary>
        /// <remarks>
        /// Order to make available empty containers.
        /// </remarks>
        EmptyContainerDispositionOrder,

        /// <summary>
        /// Cargo vessel discharge order (Code: 145)
        /// </summary>
        /// <remarks>
        /// Order that the containers or cargo specified are to be discharged from a vessel.
        /// </remarks>
        CargoVesselDischargeOrder,

        /// <summary>
        /// Cargo vessel loading order (Code: 146)
        /// </summary>
        /// <remarks>
        /// Order that specified cargo, containers or groups of containers are to be loaded in or on a vessel.
        /// </remarks>
        CargoVesselLoadingOrder,

        /// <summary>
        /// Multidrop order (Code: 147)
        /// </summary>
        /// <remarks>
        /// One purchase order that contains the orders of two or more vendors and the associated delivery points for each.
        /// </remarks>
        MultidropOrder,

        /// <summary>
        /// Bailment contract (Code: 148)
        /// </summary>
        /// <remarks>
        /// A document authorizing the bailing of goods.
        /// </remarks>
        BailmentContract,

        /// <summary>
        /// Basic agreement (Code: 149)
        /// </summary>
        /// <remarks>
        /// A document indicating an agreement containing basic terms and conditions applicable to future contracts between two parties.
        /// </remarks>
        BasicAgreement,

        /// <summary>
        /// Internal transport order (Code: 150)
        /// </summary>
        /// <remarks>
        /// Document/message giving instructions about the transport of goods within an enterprise.
        /// </remarks>
        InternalTransportOrder,

        /// <summary>
        /// Grant (Code: 151)
        /// </summary>
        /// <remarks>
        /// A document indicating the granting of funds.
        /// </remarks>
        Grant,

        /// <summary>
        /// Indefinite delivery indefinite quantity contract (Code: 152)
        /// </summary>
        /// <remarks>
        /// A document indicating a contract calling for the indefinite deliveries of indefinite quantities of goods.
        /// </remarks>
        IndefiniteDeliveryIndefiniteQuantityContract,

        /// <summary>
        /// Indefinite delivery definite quantity contract (Code: 153)
        /// </summary>
        /// <remarks>
        /// A document indicating a contract calling for indefinite deliveries of definite quantities.
        /// </remarks>
        IndefiniteDeliveryDefiniteQuantityContract,

        /// <summary>
        /// Requirements contract (Code: 154)
        /// </summary>
        /// <remarks>
        /// A document indicating a requirements contract that authorizes the filling of all purchase requirements during a specified contract period.
        /// </remarks>
        RequirementsContract,

        /// <summary>
        /// Task order (Code: 155)
        /// </summary>
        /// <remarks>
        /// A document indicating an order that tasks a contractor to perform a specified function.
        /// </remarks>
        TaskOrder,

        /// <summary>
        /// Make or buy plan (Code: 156)
        /// </summary>
        /// <remarks>
        /// A document indicating a plan that identifies which items will be made and which items will be bought.
        /// </remarks>
        MakeOrBuyPlan,

        /// <summary>
        /// Subcontractor plan (Code: 157)
        /// </summary>
        /// <remarks>
        /// A document indicating a plan that identifies the manufacturer's subcontracting strategy for a specific contract.
        /// </remarks>
        SubcontractorPlan,

        /// <summary>
        /// Cost data summary (Code: 158)
        /// </summary>
        /// <remarks>
        /// A document indicating a summary of cost data.
        /// </remarks>
        CostDataSummary,

        /// <summary>
        /// Certified cost and price data (Code: 159)
        /// </summary>
        /// <remarks>
        /// A document indicating cost and price data whose accuracy has been certified.
        /// </remarks>
        CertifiedCostAndPriceData,

        /// <summary>
        /// Wage determination (Code: 160)
        /// </summary>
        /// <remarks>
        /// A document indicating a determination of the wages to be paid.
        /// </remarks>
        WageDetermination,

        /// <summary>
        /// Contract Funds Status Report (CFSR) (Code: 161)
        /// </summary>
        /// <remarks>
        /// A report to provide the status of funds applicable to the contract.
        /// </remarks>
        ContractFundsStatusReportCFSR,

        /// <summary>
        /// Certified inspection and test results (Code: 162)
        /// </summary>
        /// <remarks>
        /// A certification as to the accuracy of inspection and test results.
        /// </remarks>
        CertifiedInspectionAndTestResults,

        /// <summary>
        /// Material inspection and receiving report (Code: 163)
        /// </summary>
        /// <remarks>
        /// A report that is both an inspection report for materials and a receiving document.
        /// </remarks>
        MaterialInspectionAndReceivingReport,

        /// <summary>
        /// Purchasing specification (Code: 164)
        /// </summary>
        /// <remarks>
        /// A document indicating a specification used to purchase an item.
        /// </remarks>
        PurchasingSpecification,

        /// <summary>
        /// Payment or performance bond (Code: 165)
        /// </summary>
        /// <remarks>
        /// A document indicating a bond that guarantees the payment of monies or a performance.
        /// </remarks>
        PaymentOrPerformanceBond,

        /// <summary>
        /// Contract security classification specification (Code: 166)
        /// </summary>
        /// <remarks>
        /// A document that indicates the specification contains the security and classification requirements for a contract.
        /// </remarks>
        ContractSecurityClassificationSpecification,

        /// <summary>
        /// Manufacturing specification (Code: 167)
        /// </summary>
        /// <remarks>
        /// A document indicating the specification of how an item is to be manufactured.
        /// </remarks>
        ManufacturingSpecification,

        /// <summary>
        /// Buy America certificate of compliance (Code: 168)
        /// </summary>
        /// <remarks>
        /// A document certifying that more than 50 percent of the cost of an item is attributed to US origin.
        /// </remarks>
        BuyAmericaCertificateOfCompliance,

        /// <summary>
        /// Container off-hire notice (Code: 169)
        /// </summary>
        /// <remarks>
        /// Notice to return leased containers.
        /// </remarks>
        ContainerOffHireNotice,

        /// <summary>
        /// Cargo acceptance order (Code: 170)
        /// </summary>
        /// <remarks>
        /// Order to accept cargo to be delivered by a carrier.
        /// </remarks>
        CargoAcceptanceOrder,

        /// <summary>
        /// Pick-up notice (Code: 171)
        /// </summary>
        /// <remarks>
        /// Notice specifying the pick-up of released cargo or containers from a certain address.
        /// </remarks>
        PickUpNotice,

        /// <summary>
        /// Authorisation to plan and suggest orders (Code: 172)
        /// </summary>
        /// <remarks>
        /// Document or message that authorises receiver to plan orders, based on information in this message, and send these orders as suggestions to the sender.
        /// </remarks>
        AuthorisationToPlanAndSuggestOrders,

        /// <summary>
        /// Authorisation to plan and ship orders (Code: 173)
        /// </summary>
        /// <remarks>
        /// Document or message that authorises receiver to plan and ship orders based on information in this message.
        /// </remarks>
        AuthorisationToPlanAndShipOrders,

        /// <summary>
        /// Drawing (Code: 174)
        /// </summary>
        /// <remarks>
        /// The document or message is a drawing.
        /// </remarks>
        Drawing,

        /// <summary>
        /// Cost Performance Report (CPR) format 2 (Code: 175)
        /// </summary>
        /// <remarks>
        /// A report identifying the cost performance on a contract at specified levels of the work breakdown structure (format 2 - organizational categories).
        /// </remarks>
        CostPerformanceReportCPRFormat2,

        /// <summary>
        /// Cost Schedule Status Report (CSSR) (Code: 176)
        /// </summary>
        /// <remarks>
        /// A report providing the status of the cost and schedule applicable to a contract.
        /// </remarks>
        CostScheduleStatusReportCSSR,

        /// <summary>
        /// Cost Performance Report (CPR) format 1 (Code: 177)
        /// </summary>
        /// <remarks>
        /// A report identifying the cost performance on a contract including the current month's values at specified levels of the work breakdown structure (format 1 - work breakdown structure).
        /// </remarks>
        CostPerformanceReportCPRFormat1,

        /// <summary>
        /// Cost Performance Report (CPR) format 3 (Code: 178)
        /// </summary>
        /// <remarks>
        /// A report identifying the cost performance on a contract that summarizes changes to a contract over a given reporting period with beginning and ending values (format 3 - baseline).
        /// </remarks>
        CostPerformanceReportCPRFormat3,

        /// <summary>
        /// Cost Performance Report (CPR) format 4 (Code: 179)
        /// </summary>
        /// <remarks>
        /// A report identifying the cost performance on a contract including forecasts of labour requirements for the remaining portion of the contract (format 4 - staffing).
        /// </remarks>
        CostPerformanceReportCPRFormat4,

        /// <summary>
        /// Cost Performance Report (CPR) format 5 (Code: 180)
        /// </summary>
        /// <remarks>
        /// A report identifying the cost performance on a contract that summarizes cost or schedule variances (format 5 - explanations and problem analysis).
        /// </remarks>
        CostPerformanceReportCPRFormat5,

        /// <summary>
        /// Progressive discharge report (Code: 181)
        /// </summary>
        /// <remarks>
        /// Document or message progressively issued by the container terminal operator in charge of discharging a vessel identifying containers that have been discharged from a specific vessel at that point in time.
        /// </remarks>
        ProgressiveDischargeReport,

        /// <summary>
        /// Balance confirmation (Code: 182)
        /// </summary>
        /// <remarks>
        /// Confirmation of a balance at an entry date.
        /// </remarks>
        BalanceConfirmation,

        /// <summary>
        /// Container stripping order (Code: 183)
        /// </summary>
        /// <remarks>
        /// Order to unload goods from a container.
        /// </remarks>
        ContainerStrippingOrder,

        /// <summary>
        /// Container stuffing order (Code: 184)
        /// </summary>
        /// <remarks>
        /// Order to stuff specified goods or consignments in a container.
        /// </remarks>
        ContainerStuffingOrder,

        /// <summary>
        /// Conveyance declaration (arrival) (Code: 185)
        /// </summary>
        /// <remarks>
        /// Declaration to the public authority upon arrival of the conveyance.
        /// </remarks>
        ConveyanceDeclarationArrival,

        /// <summary>
        /// Conveyance declaration (departure) (Code: 186)
        /// </summary>
        /// <remarks>
        /// Declaration to the public authority upon departure of the conveyance.
        /// </remarks>
        ConveyanceDeclarationDeparture,

        /// <summary>
        /// Conveyance declaration (combined) (Code: 187)
        /// </summary>
        /// <remarks>
        /// Combined declaration of arrival and departure to the public authority.
        /// </remarks>
        ConveyanceDeclarationCombined,

        /// <summary>
        /// Project recovery plan (Code: 188)
        /// </summary>
        /// <remarks>
        /// A project plan for recovery after a delay or problem resolution.
        /// </remarks>
        ProjectRecoveryPlan,

        /// <summary>
        /// Project production plan (Code: 189)
        /// </summary>
        /// <remarks>
        /// A project plan for the production of goods.
        /// </remarks>
        ProjectProductionPlan,

        /// <summary>
        /// Statistical and other administrative internal documents (Code: 190)
        /// </summary>
        /// <remarks>
        /// Documents/messages issued within an enterprise for the for the purpose of collection of production and other internal statistics, and for other administration purposes.
        /// </remarks>
        StatisticalAndOtherAdministrativeInternalDocuments,

        /// <summary>
        /// Project master schedule (Code: 191)
        /// </summary>
        /// <remarks>
        /// A high level, all encompassing master schedule of activities to complete a project.
        /// </remarks>
        ProjectMasterSchedule,

        /// <summary>
        /// Priced alternate tender bill of quantity (Code: 192)
        /// </summary>
        /// <remarks>
        /// A priced tender based upon an alternate specification.
        /// </remarks>
        PricedAlternateTenderBillOfQuantity,

        /// <summary>
        /// Estimated priced bill of quantity (Code: 193)
        /// </summary>
        /// <remarks>
        /// An estimate based upon a detailed, quantity based specification (bill of quantity).
        /// </remarks>
        EstimatedPricedBillOfQuantity,

        /// <summary>
        /// Draft bill of quantity (Code: 194)
        /// </summary>
        /// <remarks>
        /// Document/message providing a draft bill of quantity, issued in an unpriced form.
        /// </remarks>
        DraftBillOfQuantity,

        /// <summary>
        /// Documentary credit collection instruction (Code: 195)
        /// </summary>
        /// <remarks>
        /// Instruction for the collection of the documentary credit.
        /// </remarks>
        DocumentaryCreditCollectionInstruction,

        /// <summary>
        /// Request for an amendment of a documentary credit (Code: 196)
        /// </summary>
        /// <remarks>
        /// Request for an amendment of a documentary credit.
        /// </remarks>
        RequestForAnAmendmentOfADocumentaryCredit,

        /// <summary>
        /// Documentary credit amendment information (Code: 197)
        /// </summary>
        /// <remarks>
        /// Documentary credit amendment information.
        /// </remarks>
        DocumentaryCreditAmendmentInformation,

        /// <summary>
        /// Advice of an amendment of a documentary credit (Code: 198)
        /// </summary>
        /// <remarks>
        /// Advice of an amendment of a documentary credit.
        /// </remarks>
        AdviceOfAnAmendmentOfADocumentaryCredit,

        /// <summary>
        /// Response to an amendment of a documentary credit (Code: 199)
        /// </summary>
        /// <remarks>
        /// Response to an amendment of a documentary credit.
        /// </remarks>
        ResponseToAnAmendmentOfADocumentaryCredit,

        /// <summary>
        /// Documentary credit issuance information (Code: 200)
        /// </summary>
        /// <remarks>
        /// Provides information on documentary credit issuance.
        /// </remarks>
        DocumentaryCreditIssuanceInformation,

        /// <summary>
        /// Direct payment valuation request (Code: 201)
        /// </summary>
        /// <remarks>
        /// Request to establish a direct payment valuation.
        /// </remarks>
        DirectPaymentValuationRequest,

        /// <summary>
        /// Direct payment valuation (Code: 202)
        /// </summary>
        /// <remarks>
        /// Document/message addressed, for instance, by a general contractor to the owner, in order that a direct payment be made to a subcontractor.
        /// </remarks>
        DirectPaymentValuation,

        /// <summary>
        /// Provisional payment valuation (Code: 203)
        /// </summary>
        /// <remarks>
        /// Document/message establishing a provisional payment valuation.
        /// </remarks>
        ProvisionalPaymentValuation,

        /// <summary>
        /// Payment valuation (Code: 204)
        /// </summary>
        /// <remarks>
        /// Document/message establishing the financial elements of a situation of works.
        /// </remarks>
        PaymentValuation,

        /// <summary>
        /// Quantity valuation (Code: 205)
        /// </summary>
        /// <remarks>
        /// Document/message providing a confirmed assessment, by quantity, of the completed work for a construction contract.
        /// </remarks>
        QuantityValuation,

        /// <summary>
        /// Quantity valuation request (Code: 206)
        /// </summary>
        /// <remarks>
        /// Document/message providing an initial assessment, by quantity, of the completed work for a construction contract.
        /// </remarks>
        QuantityValuationRequest,

        /// <summary>
        /// Contract bill of quantities - BOQ (Code: 207)
        /// </summary>
        /// <remarks>
        /// Document/message providing a formal specification identifying quantities and prices that are the basis of a contract for a construction project. BOQ means: Bill of quantity.
        /// </remarks>
        ContractBillOfQuantitiesBOQ,

        /// <summary>
        /// Unpriced bill of quantity (Code: 208)
        /// </summary>
        /// <remarks>
        /// Document/message providing a detailed, quantity based specification, issued in an unpriced form to invite tender prices.
        /// </remarks>
        UnpricedBillOfQuantity,

        /// <summary>
        /// Priced tender BOQ (Code: 209)
        /// </summary>
        /// <remarks>
        /// Document/message providing a detailed, quantity based specification, updated with prices to form a tender submission for a construction contract. BOQ means: Bill of quantity.
        /// </remarks>
        PricedTenderBOQ,

        /// <summary>
        /// Enquiry (Code: 210)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a party interested in the purchase of goods specified therein and indicating particular, desirable conditions regarding delivery terms, etc., addressed to a prospective supplier with a view to obtaining an offer.
        /// </remarks>
        Enquiry,

        /// <summary>
        /// Interim application for payment (Code: 211)
        /// </summary>
        /// <remarks>
        /// Document/message containing a provisional assessment in support of a request for payment for completed work for a construction contract.
        /// </remarks>
        InterimApplicationForPayment,

        /// <summary>
        /// Agreement to pay (Code: 212)
        /// </summary>
        /// <remarks>
        /// Document/message in which the debtor expresses the intention to pay.
        /// </remarks>
        AgreementToPay,

        /// <summary>
        /// Request for financial cancellation (Code: 213)
        /// </summary>
        /// <remarks>
        /// The message is a request for financial cancellation.
        /// </remarks>
        RequestForFinancialCancellation,

        /// <summary>
        /// Pre-authorised direct debit(s) (Code: 214)
        /// </summary>
        /// <remarks>
        /// The message contains pre-authorised direct debit(s).
        /// </remarks>
        PreAuthorisedDirectDebits,

        /// <summary>
        /// Letter of intent (Code: 215)
        /// </summary>
        /// <remarks>
        /// Document/message by means of which a buyer informs a seller that the buyer intends to enter into contractual negotiations.
        /// </remarks>
        LetterOfIntent,

        /// <summary>
        /// Approved unpriced bill of quantity (Code: 216)
        /// </summary>
        /// <remarks>
        /// Document/message providing an approved detailed, quantity based specification (bill of quantity), in an unpriced form.
        /// </remarks>
        ApprovedUnpricedBillOfQuantity,

        /// <summary>
        /// Payment valuation for unscheduled items (Code: 217)
        /// </summary>
        /// <remarks>
        /// A payment valuation for unscheduled items.
        /// </remarks>
        PaymentValuationForUnscheduledItems,

        /// <summary>
        /// Final payment request based on completion of work (Code: 218)
        /// </summary>
        /// <remarks>
        /// The final payment request of a series of payment requests submitted upon completion of all the work.
        /// </remarks>
        FinalPaymentRequestBasedOnCompletionOfWork,

        /// <summary>
        /// Payment request for completed units (Code: 219)
        /// </summary>
        /// <remarks>
        /// A request for payment for completed units.
        /// </remarks>
        PaymentRequestForCompletedUnits,

        /// <summary>
        /// Order (Code: 220)
        /// </summary>
        /// <remarks>
        /// Document/message by means of which a buyer initiates a transaction with a seller involving the supply of goods or services as specified, according to conditions set out in an offer, or otherwise known to the buyer.
        /// </remarks>
        Order,

        /// <summary>
        /// Blanket order (Code: 221)
        /// </summary>
        /// <remarks>
        /// Usage of document/message for general order purposes with later split into quantities and delivery dates and maybe delivery locations.
        /// </remarks>
        BlanketOrder,

        /// <summary>
        /// Spot order (Code: 222)
        /// </summary>
        /// <remarks>
        /// Document/message ordering the remainder of a production's batch.
        /// </remarks>
        SpotOrder,

        /// <summary>
        /// Lease order (Code: 223)
        /// </summary>
        /// <remarks>
        /// Document/message for goods in leasing contracts.
        /// </remarks>
        LeaseOrder,

        /// <summary>
        /// Rush order (Code: 224)
        /// </summary>
        /// <remarks>
        /// Document/message for urgent ordering.
        /// </remarks>
        RushOrder,

        /// <summary>
        /// Repair order (Code: 225)
        /// </summary>
        /// <remarks>
        /// Document/message to order repair of goods.
        /// </remarks>
        RepairOrder,

        /// <summary>
        /// Call off order (Code: 226)
        /// </summary>
        /// <remarks>
        /// Document/message to provide split quantities and delivery dates referring to a previous blanket order.
        /// </remarks>
        CallOffOrder,

        /// <summary>
        /// Consignment order (Code: 227)
        /// </summary>
        /// <remarks>
        /// Order to deliver goods into stock with agreement on payment when goods are sold out of this stock.
        /// </remarks>
        ConsignmentOrder,

        /// <summary>
        /// Sample order (Code: 228)
        /// </summary>
        /// <remarks>
        /// Document/message to order samples.
        /// </remarks>
        SampleOrder,

        /// <summary>
        /// Swap order (Code: 229)
        /// </summary>
        /// <remarks>
        /// Document/message informing buyer or seller of the replacement of goods previously ordered.
        /// </remarks>
        SwapOrder,

        /// <summary>
        /// Purchase order change request (Code: 230)
        /// </summary>
        /// <remarks>
        /// Change to an purchase order already sent.
        /// </remarks>
        PurchaseOrderChangeRequest,

        /// <summary>
        /// Purchase order response (Code: 231)
        /// </summary>
        /// <remarks>
        /// Response to an purchase order already received.
        /// </remarks>
        PurchaseOrderResponse,

        /// <summary>
        /// Hire order (Code: 232)
        /// </summary>
        /// <remarks>
        /// Document/message for hiring human resources or renting goods or equipment.
        /// </remarks>
        HireOrder,

        /// <summary>
        /// Spare parts order (Code: 233)
        /// </summary>
        /// <remarks>
        /// Document/message to order spare parts.
        /// </remarks>
        SparePartsOrder,

        /// <summary>
        /// Campaign price/sales catalogue (Code: 234)
        /// </summary>
        /// <remarks>
        /// A price/sales catalogue containing special prices which are valid only for a specified period or under specified conditions.
        /// </remarks>
        CampaignPricesalesCatalogue,

        /// <summary>
        /// Container list (Code: 235)
        /// </summary>
        /// <remarks>
        /// Document or message issued by party identifying the containers for which they are responsible.
        /// </remarks>
        ContainerList,

        /// <summary>
        /// Delivery forecast (Code: 236)
        /// </summary>
        /// <remarks>
        /// A message which enables the transmission of delivery or product forecasting requirements.
        /// </remarks>
        DeliveryForecast,

        /// <summary>
        /// Cross docking services order (Code: 237)
        /// </summary>
        /// <remarks>
        /// A document or message to order cross docking services.
        /// </remarks>
        CrossDockingServicesOrder,

        /// <summary>
        /// Non-pre-authorised direct debit(s) (Code: 238)
        /// </summary>
        /// <remarks>
        /// The message contains non-pre-authorised direct debit(s).
        /// </remarks>
        NonPreAuthorisedDirectDebits,

        /// <summary>
        /// Rejected direct debit(s) (Code: 239)
        /// </summary>
        /// <remarks>
        /// The message contains rejected direct debit(s).
        /// </remarks>
        RejectedDirectDebits,

        /// <summary>
        /// Delivery instructions (Code: 240)
        /// </summary>
        /// <remarks>
        /// (1174) Document/message giving instruction regarding the delivery of goods.
        /// </remarks>
        DeliveryInstructions,

        /// <summary>
        /// Delivery schedule (Code: 241)
        /// </summary>
        /// <remarks>
        /// Usage of DELFOR-message.
        /// </remarks>
        DeliverySchedule,

        /// <summary>
        /// Delivery just-in-time (Code: 242)
        /// </summary>
        /// <remarks>
        /// Usage of DELJIT-message.
        /// </remarks>
        DeliveryJustInTime,

        /// <summary>
        /// Pre-authorised direct debit request(s) (Code: 243)
        /// </summary>
        /// <remarks>
        /// The message contains pre-authorised direct debit request(s).
        /// </remarks>
        PreAuthorisedDirectDebitRequests,

        /// <summary>
        /// Non-pre-authorised direct debit request(s) (Code: 244)
        /// </summary>
        /// <remarks>
        /// The message contains non-pre-authorised direct debit request(s).
        /// </remarks>
        NonPreAuthorisedDirectDebitRequests,

        /// <summary>
        /// Delivery release (Code: 245)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a buyer releasing the despatch of goods after receipt of the Ready for despatch advice from the seller.
        /// </remarks>
        DeliveryRelease,

        /// <summary>
        /// Settlement of a letter of credit (Code: 246)
        /// </summary>
        /// <remarks>
        /// Settlement of a letter of credit.
        /// </remarks>
        SettlementOfALetterOfCredit,

        /// <summary>
        /// Bank to bank funds transfer (Code: 247)
        /// </summary>
        /// <remarks>
        /// The message is a bank to bank funds transfer.
        /// </remarks>
        BankToBankFundsTransfer,

        /// <summary>
        /// Customer payment order(s) (Code: 248)
        /// </summary>
        /// <remarks>
        /// The message contains customer payment order(s).
        /// </remarks>
        CustomerPaymentOrders,

        /// <summary>
        /// Low value payment order(s) (Code: 249)
        /// </summary>
        /// <remarks>
        /// The message contains low value payment order(s) only.
        /// </remarks>
        LowValuePaymentOrders,

        /// <summary>
        /// Crew list declaration (Code: 250)
        /// </summary>
        /// <remarks>
        /// Declaration regarding crew members aboard the conveyance.
        /// </remarks>
        CrewListDeclaration,

        /// <summary>
        /// Inquiry (Code: 251)
        /// </summary>
        /// <remarks>
        /// This is a request for information.
        /// </remarks>
        Inquiry,

        /// <summary>
        /// Response to previous banking status message (Code: 252)
        /// </summary>
        /// <remarks>
        /// A response to a previously sent banking status message.
        /// </remarks>
        ResponseToPreviousBankingStatusMessage,

        /// <summary>
        /// Project master plan (Code: 253)
        /// </summary>
        /// <remarks>
        /// A high level, all encompassing master plan to complete a project.
        /// </remarks>
        ProjectMasterPlan,

        /// <summary>
        /// Project plan (Code: 254)
        /// </summary>
        /// <remarks>
        /// A plan for project work to be completed.
        /// </remarks>
        ProjectPlan,

        /// <summary>
        /// Project schedule (Code: 255)
        /// </summary>
        /// <remarks>
        /// A schedule of project activities to be completed.
        /// </remarks>
        ProjectSchedule,

        /// <summary>
        /// Project planning available resources (Code: 256)
        /// </summary>
        /// <remarks>
        /// Available resources for project planning purposes.
        /// </remarks>
        ProjectPlanningAvailableResources,

        /// <summary>
        /// Project planning calendar (Code: 257)
        /// </summary>
        /// <remarks>
        /// Work calendar information for project planning purposes.
        /// </remarks>
        ProjectPlanningCalendar,

        /// <summary>
        /// Standing order (Code: 258)
        /// </summary>
        /// <remarks>
        /// An order to supply fixed quantities of products at fixed regular intervals.
        /// </remarks>
        StandingOrder,

        /// <summary>
        /// Cargo movement event log (Code: 259)
        /// </summary>
        /// <remarks>
        /// A document detailing times and dates of events pertaining to a cargo movement.
        /// </remarks>
        CargoMovementEventLog,

        /// <summary>
        /// Cargo analysis voyage report (Code: 260)
        /// </summary>
        /// <remarks>
        /// An analysis of the cargo for a voyage.
        /// </remarks>
        CargoAnalysisVoyageReport,

        /// <summary>
        /// Self billed credit note (Code: 261)
        /// </summary>
        /// <remarks>
        /// A document which indicates that the customer is claiming credit in a self billing environment.
        /// </remarks>
        SelfBilledCreditNote,

        /// <summary>
        /// Consolidated credit note - goods and services (Code: 262)
        /// </summary>
        /// <remarks>
        /// Credit note for goods and services that covers multiple transactions involving more than one invoice.
        /// </remarks>
        ConsolidatedCreditNoteGoodsAndServices,

        /// <summary>
        /// Inventory adjustment status report (Code: 263)
        /// </summary>
        /// <remarks>
        /// A message detailing statuses related to the adjustment of inventory.
        /// </remarks>
        InventoryAdjustmentStatusReport,

        /// <summary>
        /// Transport equipment movement instruction (Code: 264)
        /// </summary>
        /// <remarks>
        /// Instruction to perform one or more different movements of transport equipment.
        /// </remarks>
        TransportEquipmentMovementInstruction,

        /// <summary>
        /// Transport equipment movement report (Code: 265)
        /// </summary>
        /// <remarks>
        /// Report on one or more different movements of transport equipment.
        /// </remarks>
        TransportEquipmentMovementReport,

        /// <summary>
        /// Transport equipment status change report (Code: 266)
        /// </summary>
        /// <remarks>
        /// Report on one or more changes of status associated with an item or items of transport equipment.
        /// </remarks>
        TransportEquipmentStatusChangeReport,

        /// <summary>
        /// Fumigation certificate (Code: 267)
        /// </summary>
        /// <remarks>
        /// Certificate attesting that fumigation has been performed.
        /// </remarks>
        FumigationCertificate,

        /// <summary>
        /// Wine certificate (Code: 268)
        /// </summary>
        /// <remarks>
        /// Certificate attesting to the quality, origin or appellation of wine.
        /// </remarks>
        WineCertificate,

        /// <summary>
        /// Wool health certificate (Code: 269)
        /// </summary>
        /// <remarks>
        /// Certificate attesting that wool is free from specified risks to human or animal health.
        /// </remarks>
        WoolHealthCertificate,

        /// <summary>
        /// Delivery note (Code: 270)
        /// </summary>
        /// <remarks>
        /// Paper document attached to a consignment informing the receiving party about contents of this consignment.
        /// </remarks>
        DeliveryNote,

        /// <summary>
        /// Packing list (Code: 271)
        /// </summary>
        /// <remarks>
        /// Document/message specifying the distribution of goods in individual packages (in trade environment the despatch advice message is used for the packing list).
        /// </remarks>
        PackingList,

        /// <summary>
        /// New code request (Code: 272)
        /// </summary>
        /// <remarks>
        /// Requesting a new code.
        /// </remarks>
        NewCodeRequest,

        /// <summary>
        /// Code change request (Code: 273)
        /// </summary>
        /// <remarks>
        /// Request a change to an existing code.
        /// </remarks>
        CodeChangeRequest,

        /// <summary>
        /// Simple data element request (Code: 274)
        /// </summary>
        /// <remarks>
        /// Requesting a new simple data element.
        /// </remarks>
        SimpleDataElementRequest,

        /// <summary>
        /// Simple data element change request (Code: 275)
        /// </summary>
        /// <remarks>
        /// Request a change to an existing simple data element.
        /// </remarks>
        SimpleDataElementChangeRequest,

        /// <summary>
        /// Composite data element request (Code: 276)
        /// </summary>
        /// <remarks>
        /// Requesting a new composite data element.
        /// </remarks>
        CompositeDataElementRequest,

        /// <summary>
        /// Composite data element change request (Code: 277)
        /// </summary>
        /// <remarks>
        /// Request a change to an existing composite data element.
        /// </remarks>
        CompositeDataElementChangeRequest,

        /// <summary>
        /// Segment request (Code: 278)
        /// </summary>
        /// <remarks>
        /// Request a new segment.
        /// </remarks>
        SegmentRequest,

        /// <summary>
        /// Segment change request (Code: 279)
        /// </summary>
        /// <remarks>
        /// Requesting a change to an existing segment.
        /// </remarks>
        SegmentChangeRequest,

        /// <summary>
        /// New message request (Code: 280)
        /// </summary>
        /// <remarks>
        /// Request for a new message (NMR).
        /// </remarks>
        NewMessageRequest,

        /// <summary>
        /// Message in development request (Code: 281)
        /// </summary>
        /// <remarks>
        /// Requesting a Message in Development (MiD).
        /// </remarks>
        MessageInDevelopmentRequest,

        /// <summary>
        /// Modification of existing message (Code: 282)
        /// </summary>
        /// <remarks>
        /// Requesting a change to an existing message.
        /// </remarks>
        ModificationOfExistingMessage,

        /// <summary>
        /// Tracking number assignment report (Code: 283)
        /// </summary>
        /// <remarks>
        /// Report of assigned tracking numbers.
        /// </remarks>
        TrackingNumberAssignmentReport,

        /// <summary>
        /// User directory definition (Code: 284)
        /// </summary>
        /// <remarks>
        /// Document/message defining the contents of a user directory set or parts thereof.
        /// </remarks>
        UserDirectoryDefinition,

        /// <summary>
        /// United Nations standard message request (Code: 285)
        /// </summary>
        /// <remarks>
        /// Requesting a United Nations Standard Message (UNSM).
        /// </remarks>
        UnitedNationsStandardMessageRequest,

        /// <summary>
        /// Service directory definition (Code: 286)
        /// </summary>
        /// <remarks>
        /// Document/message defining the contents of a service directory set or parts thereof.
        /// </remarks>
        ServiceDirectoryDefinition,

        /// <summary>
        /// Status report (Code: 287)
        /// </summary>
        /// <remarks>
        /// Message covers information about the status.
        /// </remarks>
        StatusReport,

        /// <summary>
        /// Kanban schedule (Code: 288)
        /// </summary>
        /// <remarks>
        /// Message to describe a Kanban schedule.
        /// </remarks>
        KanbanSchedule,

        /// <summary>
        /// Product data message (Code: 289)
        /// </summary>
        /// <remarks>
        /// A message to submit master data, a set of data that is rarely changed, to identify and describe products a supplier offers to their (potential) customer or buyer.
        /// </remarks>
        ProductDataMessage,

        /// <summary>
        /// A claim for parts and/or labour charges (Code: 290)
        /// </summary>
        /// <remarks>
        /// A claim for parts and/or labour charges incurred .
        /// </remarks>
        AClaimForPartsAndorLabourCharges,

        /// <summary>
        /// Delivery schedule response (Code: 291)
        /// </summary>
        /// <remarks>
        /// A message providing a response to a previously transmitted delivery schedule.
        /// </remarks>
        DeliveryScheduleResponse,

        /// <summary>
        /// Inspection request (Code: 292)
        /// </summary>
        /// <remarks>
        /// A message requesting a party to inspect items.
        /// </remarks>
        InspectionRequest,

        /// <summary>
        /// Inspection report (Code: 293)
        /// </summary>
        /// <remarks>
        /// A message informing a party of the results of an inspection.
        /// </remarks>
        InspectionReport,

        /// <summary>
        /// Application acknowledgement and error report (Code: 294)
        /// </summary>
        /// <remarks>
        /// A message used by an application to acknowledge reception of a message and/or to report any errors.
        /// </remarks>
        ApplicationAcknowledgementAndErrorReport,

        /// <summary>
        /// Price variation invoice (Code: 295)
        /// </summary>
        /// <remarks>
        /// An invoice which requests payment for the difference in price between an original invoice and the result of the application of a price variation formula.
        /// </remarks>
        PriceVariationInvoice,

        /// <summary>
        /// Credit note for price variation (Code: 296)
        /// </summary>
        /// <remarks>
        /// A credit note which is issued against a price variation invoice.
        /// </remarks>
        CreditNoteForPriceVariation,

        /// <summary>
        /// Instruction to collect (Code: 297)
        /// </summary>
        /// <remarks>
        /// A message instructing a party to collect goods.
        /// </remarks>
        InstructionToCollect,

        /// <summary>
        /// Dangerous goods list (Code: 298)
        /// </summary>
        /// <remarks>
        /// Listing of all details of dangerous goods carried.
        /// </remarks>
        DangerousGoodsList,

        /// <summary>
        /// Registration renewal (Code: 299)
        /// </summary>
        /// <remarks>
        /// Code specifying the continued validity of previously submitted registration information.
        /// </remarks>
        RegistrationRenewal,

        /// <summary>
        /// Registration change (Code: 300)
        /// </summary>
        /// <remarks>
        /// Code specifying the modification of previously submitted registration information.
        /// </remarks>
        RegistrationChange,

        /// <summary>
        /// Response to registration (Code: 301)
        /// </summary>
        /// <remarks>
        /// Code specifying a response to an occurrence of a registration message.
        /// </remarks>
        ResponseToRegistration,

        /// <summary>
        /// Implementation guideline (Code: 302)
        /// </summary>
        /// <remarks>
        /// A document specifying the criterion and format for exchanging information in an electronic data interchange syntax.
        /// </remarks>
        ImplementationGuideline,

        /// <summary>
        /// Request for transfer (Code: 303)
        /// </summary>
        /// <remarks>
        /// Document/message is a request for transfer.
        /// </remarks>
        RequestForTransfer,

        /// <summary>
        /// Cost performance report (Code: 304)
        /// </summary>
        /// <remarks>
        /// A report to convey cost performance data for a project or contract.
        /// </remarks>
        CostPerformanceReport,

        /// <summary>
        /// Application error and acknowledgement (Code: 305)
        /// </summary>
        /// <remarks>
        /// A message to inform a message issuer that a previously sent message has been received by the addressee's application, or that a previously sent message has been rejected by the addressee's application.
        /// </remarks>
        ApplicationErrorAndAcknowledgement,

        /// <summary>
        /// Cash pool financial statement (Code: 306)
        /// </summary>
        /// <remarks>
        /// A financial statement for a cash pool.
        /// </remarks>
        CashPoolFinancialStatement,

        /// <summary>
        /// Sequenced delivery schedule (Code: 307)
        /// </summary>
        /// <remarks>
        /// Message to describe a sequence of product delivery.
        /// </remarks>
        SequencedDeliverySchedule,

        /// <summary>
        /// Delcredere credit note (Code: 308)
        /// </summary>
        /// <remarks>
        /// A credit note sent to the party paying on behalf of a number of buyers.
        /// </remarks>
        DelcredereCreditNote,

        /// <summary>
        /// Healthcare discharge report, final (Code: 309)
        /// </summary>
        /// <remarks>
        /// Final discharge report by healthcare provider.
        /// </remarks>
        HealthcareDischargeReportfinal,

        /// <summary>
        /// Offer / quotation (Code: 310)
        /// </summary>
        /// <remarks>
        /// (1332) Document/message which, with a view to concluding a contract, sets out the conditions under which the goods are offered.
        /// </remarks>
        OfferQuotation,

        /// <summary>
        /// Request for quote (Code: 311)
        /// </summary>
        /// <remarks>
        /// Document/message requesting a quote on specified goods or services.
        /// </remarks>
        RequestForQuote,

        /// <summary>
        /// Acknowledgement message (Code: 312)
        /// </summary>
        /// <remarks>
        /// Message providing acknowledgement information at the business application level concerning the processing of a message.
        /// </remarks>
        AcknowledgementMessage,

        /// <summary>
        /// Application error message (Code: 313)
        /// </summary>
        /// <remarks>
        /// Message indicating that a message was rejected due to errors encountered at the application level.
        /// </remarks>
        ApplicationErrorMessage,

        /// <summary>
        /// Cargo movement voyage summary (Code: 314)
        /// </summary>
        /// <remarks>
        /// A consolidated voyage summary which contains the information in a certificate of analysis, a voyage analysis and a cargo movement time log for a voyage.
        /// </remarks>
        CargoMovementVoyageSummary,

        /// <summary>
        /// Contract (Code: 315)
        /// </summary>
        /// <remarks>
        /// (1296) Document/message evidencing an agreement between the seller and the buyer for the supply of goods or services; its effects are equivalent to those of an order followed by an acknowledgement of order.
        /// </remarks>
        Contract,

        /// <summary>
        /// Application for usage of berth or mooring facilities (Code: 316)
        /// </summary>
        /// <remarks>
        /// Document to apply for usage of berth or mooring facilities.
        /// </remarks>
        ApplicationForUsageOfBerthOrMooringFacilities,

        /// <summary>
        /// Application for designation of berthing places (Code: 317)
        /// </summary>
        /// <remarks>
        /// Document to apply for designation of berthing places.
        /// </remarks>
        ApplicationForDesignationOfBerthingPlaces,

        /// <summary>
        /// Application for shifting from the designated place in port (Code: 318)
        /// </summary>
        /// <remarks>
        /// Document to apply for shifting from the designated place in port.
        /// </remarks>
        ApplicationForShiftingFromTheDesignatedPlaceInPort,

        /// <summary>
        /// Supplementary document for application for cargo operation (Code: 319)
        /// </summary>
        /// <remarks>
        /// of dangerous goods Supplementary document to apply for cargo operation of dangerous goods.
        /// </remarks>
        SupplementaryDocumentForApplicationForCargoOperation,

        /// <summary>
        /// Acknowledgement of order (Code: 320)
        /// </summary>
        /// <remarks>
        /// Document/message acknowledging an undertaking to fulfil an order and confirming conditions or acceptance of conditions.
        /// </remarks>
        AcknowledgementOfOrder,

        /// <summary>
        /// Supplementary document for application for transport of (Code: 321)
        /// </summary>
        /// <remarks>
        /// dangerous goods Supplementary document to apply for transport of dangerous goods.
        /// </remarks>
        SupplementaryDocumentForApplicationForTransportOf,

        /// <summary>
        /// Optical Character Reading (OCR) payment (Code: 322)
        /// </summary>
        /// <remarks>
        /// Payment effected by an Optical Character Reading (OCR) document.
        /// </remarks>
        OpticalCharacterReadingOCRPayment,

        /// <summary>
        /// Preliminary sales report (Code: 323)
        /// </summary>
        /// <remarks>
        /// Preliminary sales report sent before all the information is available.
        /// </remarks>
        PreliminarySalesReport,

        /// <summary>
        /// Transport emergency card (Code: 324)
        /// </summary>
        /// <remarks>
        /// Official document specifying, for a given dangerous goods item, information such as nature of hazard, protective devices, actions to be taken in case of accident, spillage or fire and first aid to be given.
        /// </remarks>
        TransportEmergencyCard,

        /// <summary>
        /// Proforma invoice (Code: 325)
        /// </summary>
        /// <remarks>
        /// Document/message serving as a preliminary invoice, containing - on the whole - the same information as the final invoice, but not actually claiming payment.
        /// </remarks>
        ProformaInvoice,

        /// <summary>
        /// Partial invoice (Code: 326)
        /// </summary>
        /// <remarks>
        /// Document/message specifying details of an incomplete invoice.
        /// </remarks>
        PartialInvoice,

        /// <summary>
        /// Operating instructions (Code: 327)
        /// </summary>
        /// <remarks>
        /// Document/message describing instructions for operation.
        /// </remarks>
        OperatingInstructions,

        /// <summary>
        /// Name/product plate (Code: 328)
        /// </summary>
        /// <remarks>
        /// Plates on goods identifying and describing an article.
        /// </remarks>
        NameproductPlate,

        /// <summary>
        /// Co-insurance ceding bordereau (Code: 329)
        /// </summary>
        /// <remarks>
        /// The document or message contains a bordereau describing co-insurance ceding information.
        /// </remarks>
        CoInsuranceCedingBordereau,

        /// <summary>
        /// Request for delivery instructions (Code: 330)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a supplier requesting instructions from the buyer regarding the details of the delivery of goods ordered.
        /// </remarks>
        RequestForDeliveryInstructions,

        /// <summary>
        /// Commercial invoice which includes a packing list (Code: 331)
        /// </summary>
        /// <remarks>
        /// Commercial transaction (invoice) will include a packing list.
        /// </remarks>
        CommercialInvoiceWhichIncludesAPackingList,

        /// <summary>
        /// Trade data (Code: 332)
        /// </summary>
        /// <remarks>
        /// Document/message is for trade data.
        /// </remarks>
        TradeData,

        /// <summary>
        /// Customs declaration for cargo examination (Code: 333)
        /// </summary>
        /// <remarks>
        /// Declaration provided to customs for cargo examination.
        /// </remarks>
        CustomsDeclarationForCargoExamination,

        /// <summary>
        /// Customs declaration for cargo examination, alternate (Code: 334)
        /// </summary>
        /// <remarks>
        /// Alternate declaration provided to customs for cargo examination.
        /// </remarks>
        CustomsDeclarationForCargoExaminationalternate,

        /// <summary>
        /// Booking request (Code: 335)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a supplier to a carrier requesting space to be reserved for a specified consignment, indicating desirable conveyance, despatch time, etc.
        /// </remarks>
        BookingRequest,

        /// <summary>
        /// Customs crew and conveyance (Code: 336)
        /// </summary>
        /// <remarks>
        /// Document/message contains information regarding the crew list and conveyance.
        /// </remarks>
        CustomsCrewAndConveyance,

        /// <summary>
        /// Customs summary declaration with commercial detail, (Code: 337)
        /// </summary>
        /// <remarks>
        /// alternate Alternate Customs declaration summary with commercial transaction details.
        /// </remarks>
        CustomsSummaryDeclarationWithCommercialDetail,

        /// <summary>
        /// Items booked to a financial account report (Code: 338)
        /// </summary>
        /// <remarks>
        /// A message reporting items which have been booked to a financial account.
        /// </remarks>
        ItemsBookedToAFinancialAccountReport,

        /// <summary>
        /// Report of transactions which need further information from (Code: 339)
        /// </summary>
        /// <remarks>
        /// the receiver A message reporting transactions which need further information from the receiver.
        /// </remarks>
        ReportOfTransactionsWhichNeedFurtherInformationFrom,

        /// <summary>
        /// Shipping instructions (Code: 340)
        /// </summary>
        /// <remarks>
        /// (1121) Document/message advising details of cargo and exporter's requirements for its physical movement.
        /// </remarks>
        ShippingInstructions,

        /// <summary>
        /// Shipper's letter of instructions (air) (Code: 341)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a consignor in which he gives details of a consignment of goods that enables an airline or its agent to prepare an air waybill.
        /// </remarks>
        ShippersLetterOfInstructionsAir,

        /// <summary>
        /// Report of transactions for information only (Code: 342)
        /// </summary>
        /// <remarks>
        /// A message reporting transactions for information only.
        /// </remarks>
        ReportOfTransactionsForInformationOnly,

        /// <summary>
        /// Cartage order (local transport) (Code: 343)
        /// </summary>
        /// <remarks>
        /// Document/message giving instructions regarding local transport of goods, e.g. from the premises of an enterprise to those of a carrier undertaking further transport.
        /// </remarks>
        CartageOrderLocalTransport,

        /// <summary>
        /// EDI associated object administration message (Code: 344)
        /// </summary>
        /// <remarks>
        /// A message giving additional information about the exchange of an EDI associated object.
        /// </remarks>
        EDIAssociatedObjectAdministrationMessage,

        /// <summary>
        /// Ready for despatch advice (Code: 345)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a supplier informing a buyer that goods ordered are ready for despatch.
        /// </remarks>
        ReadyForDespatchAdvice,

        /// <summary>
        /// Summary sales report (Code: 346)
        /// </summary>
        /// <remarks>
        /// Sales report containing summaries for several earlier sent sales reports.
        /// </remarks>
        SummarySalesReport,

        /// <summary>
        /// Order status enquiry (Code: 347)
        /// </summary>
        /// <remarks>
        /// A message enquiring the status of previously sent orders.
        /// </remarks>
        OrderStatusEnquiry,

        /// <summary>
        /// Order status report (Code: 348)
        /// </summary>
        /// <remarks>
        /// A message reporting the status of previously sent orders.
        /// </remarks>
        OrderStatusReport,

        /// <summary>
        /// Declaration regarding the inward and outward movement of (Code: 349)
        /// </summary>
        /// <remarks>
        /// vessel Document to declare inward and outward movement of a vessel.
        /// </remarks>
        DeclarationRegardingTheInwardAndOutwardMovementOf,

        /// <summary>
        /// Despatch order (Code: 350)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a supplier initiating the despatch of goods to a buyer (consignee).
        /// </remarks>
        DespatchOrder,

        /// <summary>
        /// Despatch advice (Code: 351)
        /// </summary>
        /// <remarks>
        /// Document/message by means of which the seller or consignor informs the consignee about the despatch of goods.
        /// </remarks>
        DespatchAdvice,

        /// <summary>
        /// Notification of usage of berth or mooring facilities (Code: 352)
        /// </summary>
        /// <remarks>
        /// Document to notify usage of berth or mooring facilities.
        /// </remarks>
        NotificationOfUsageOfBerthOrMooringFacilities,

        /// <summary>
        /// Application for vessel's entering into port area in night- (Code: 353)
        /// </summary>
        /// <remarks>
        /// time Document to apply for vessel's entering into port area in night-time.
        /// </remarks>
        ApplicationForVesselsEnteringIntoPortAreaInNight,

        /// <summary>
        /// Notification of emergency shifting from the designated (Code: 354)
        /// </summary>
        /// <remarks>
        /// place in port Document to notify shifting from designated place in port once secured at the designated place.
        /// </remarks>
        NotificationOfEmergencyShiftingFromTheDesignated,

        /// <summary>
        /// Customs summary declaration without commercial detail, (Code: 355)
        /// </summary>
        /// <remarks>
        /// alternate Alternate Customs declaration summary without any commercial transaction details.
        /// </remarks>
        CustomsSummaryDeclarationWithoutCommercialDetail,

        /// <summary>
        /// Performance bond (Code: 356)
        /// </summary>
        /// <remarks>
        /// A document that guarantees performance.
        /// </remarks>
        PerformanceBond,

        /// <summary>
        /// Payment bond (Code: 357)
        /// </summary>
        /// <remarks>
        /// A document that guarantees the payment of monies.
        /// </remarks>
        PaymentBond,

        /// <summary>
        /// Healthcare discharge report, preliminary (Code: 358)
        /// </summary>
        /// <remarks>
        /// Preliminary discharge report by healthcare provider.
        /// </remarks>
        HealthcareDischargeReportpreliminary,

        /// <summary>
        /// Request for provision of a health service (Code: 359)
        /// </summary>
        /// <remarks>
        /// Document containing request for provision of a health service.
        /// </remarks>
        RequestForProvisionOfAHealthService,

        /// <summary>
        /// Request for price quote (Code: 360)
        /// </summary>
        /// <remarks>
        /// Document/message requesting price conditions under which goods are offered.
        /// </remarks>
        RequestForPriceQuote,

        /// <summary>
        /// Price quote (Code: 361)
        /// </summary>
        /// <remarks>
        /// Document/message confirming price conditions under which goods are offered.
        /// </remarks>
        PriceQuote,

        /// <summary>
        /// Delivery quote (Code: 362)
        /// </summary>
        /// <remarks>
        /// Document/message confirming delivery conditions under which goods are offered.
        /// </remarks>
        DeliveryQuote,

        /// <summary>
        /// Price and delivery quote (Code: 363)
        /// </summary>
        /// <remarks>
        /// Document/message confirming price and delivery conditions under which goods are offered.
        /// </remarks>
        PriceAndDeliveryQuote,

        /// <summary>
        /// Contract price quote (Code: 364)
        /// </summary>
        /// <remarks>
        /// Document/message confirming contractual price conditions under which goods are offered.
        /// </remarks>
        ContractPriceQuote,

        /// <summary>
        /// Contract price and delivery quote (Code: 365)
        /// </summary>
        /// <remarks>
        /// Document/message confirming contractual price conditions and contractual delivery conditions under which goods are offered.
        /// </remarks>
        ContractPriceAndDeliveryQuote,

        /// <summary>
        /// Price quote, specified end-customer (Code: 366)
        /// </summary>
        /// <remarks>
        /// Document/message confirming price conditions under which goods are offered, provided that they are sold to the end-customer specified on the quote.
        /// </remarks>
        PriceQuotespecifiedEndCustomer,

        /// <summary>
        /// Price and delivery quote, specified end-customer (Code: 367)
        /// </summary>
        /// <remarks>
        /// Document/message confirming price conditions and delivery conditions under which goods are offered, provided that they are sold to the end-customer specified on the quote.
        /// </remarks>
        PriceAndDeliveryQuotespecifiedEndCustomer,

        /// <summary>
        /// Price quote, ship and debit (Code: 368)
        /// </summary>
        /// <remarks>
        /// Document/message from a supplier to a distributor confirming price conditions under which goods can be sold by a distributor to the end-customer specified on the quote with compensation for loss of inventory value.
        /// </remarks>
        PriceQuoteshipAndDebit,

        /// <summary>
        /// Price and delivery quote, ship and debit (Code: 369)
        /// </summary>
        /// <remarks>
        /// Document/message from a supplier to a distributor confirming price conditions and delivery conditions under which goods can be sold by a distributor to the end-customer specified on the quote with compensation for loss of inventory value.
        /// </remarks>
        PriceAndDeliveryQuoteshipAndDebit,

        /// <summary>
        /// Advice of distribution of documents (Code: 370)
        /// </summary>
        /// <remarks>
        /// Document/message in which the party responsible for the issue of a set of trade documents specifies the various recipients of originals and copies of these documents, with an indication of the number of copies distributed to each of them.
        /// </remarks>
        AdviceOfDistributionOfDocuments,

        /// <summary>
        /// Plan for provision of health service (Code: 371)
        /// </summary>
        /// <remarks>
        /// Document containing a plan for provision of health service.
        /// </remarks>
        PlanForProvisionOfHealthService,

        /// <summary>
        /// Prescription (Code: 372)
        /// </summary>
        /// <remarks>
        /// Instructions for the dispensing and use of medicine or remedy.
        /// </remarks>
        Prescription,

        /// <summary>
        /// Prescription request (Code: 373)
        /// </summary>
        /// <remarks>
        /// Request to issue a prescription for medicine or remedy.
        /// </remarks>
        PrescriptionRequest,

        /// <summary>
        /// Prescription dispensing report (Code: 374)
        /// </summary>
        /// <remarks>
        /// Document containing information of products dispensed according to a prescription.
        /// </remarks>
        PrescriptionDispensingReport,

        /// <summary>
        /// Certificate of shipment (Code: 375)
        /// </summary>
        /// <remarks>
        /// (1109) Certificate providing confirmation that a consignment has been shipped.
        /// </remarks>
        CertificateOfShipment,

        /// <summary>
        /// Standing inquiry on product information (Code: 376)
        /// </summary>
        /// <remarks>
        /// A product inquiry which stands until it is cancelled.
        /// </remarks>
        StandingInquiryOnProductInformation,

        /// <summary>
        /// Party credit information (Code: 377)
        /// </summary>
        /// <remarks>
        /// Document/message providing data concerning the credit information of a party.
        /// </remarks>
        PartyCreditInformation,

        /// <summary>
        /// Party payment behaviour information (Code: 378)
        /// </summary>
        /// <remarks>
        /// Document/message providing data concerning the payment behaviour of a party.
        /// </remarks>
        PartyPaymentBehaviourInformation,

        /// <summary>
        /// Request for metering point information (Code: 379)
        /// </summary>
        /// <remarks>
        /// Message to request information about a metering point.
        /// </remarks>
        RequestForMeteringPointInformation,

        /// <summary>
        /// Commercial invoice (Code: 380)
        /// </summary>
        /// <remarks>
        /// (1334) Document/message claiming payment for goods or services supplied under conditions agreed between seller and buyer.
        /// </remarks>
        CommercialInvoice,

        /// <summary>
        /// Credit note (Code: 381)
        /// </summary>
        /// <remarks>
        /// (1113) Document/message for providing credit information to the relevant party.
        /// </remarks>
        CreditNote,

        /// <summary>
        /// Commission note (Code: 382)
        /// </summary>
        /// <remarks>
        /// (1111) Document/message in which a seller specifies the amount of commission, the percentage of the invoice amount, or some other basis for the calculation of the commission to which a sales agent is entitled.
        /// </remarks>
        CommissionNote,

        /// <summary>
        /// Debit note (Code: 383)
        /// </summary>
        /// <remarks>
        /// Document/message for providing debit information to the relevant party.
        /// </remarks>
        DebitNote,

        /// <summary>
        /// Corrected invoice (Code: 384)
        /// </summary>
        /// <remarks>
        /// Commercial invoice that includes revised information differing from an earlier submission of the same invoice.
        /// </remarks>
        CorrectedInvoice,

        /// <summary>
        /// Consolidated invoice (Code: 385)
        /// </summary>
        /// <remarks>
        /// Commercial invoice that covers multiple transactions involving more than one vendor.
        /// </remarks>
        ConsolidatedInvoice,

        /// <summary>
        /// Prepayment invoice (Code: 386)
        /// </summary>
        /// <remarks>
        /// An invoice to pay amounts for goods and services in advance; these amounts will be subtracted from the final invoice.
        /// </remarks>
        PrepaymentInvoice,

        /// <summary>
        /// Hire invoice (Code: 387)
        /// </summary>
        /// <remarks>
        /// Document/message for invoicing the hiring of human resources or renting goods or equipment.
        /// </remarks>
        HireInvoice,

        /// <summary>
        /// Tax invoice (Code: 388)
        /// </summary>
        /// <remarks>
        /// An invoice for tax purposes.
        /// </remarks>
        TaxInvoice,

        /// <summary>
        /// Self-billed invoice (Code: 389)
        /// </summary>
        /// <remarks>
        /// An invoice the invoicee is producing instead of the seller.
        /// </remarks>
        SelfBilledInvoice,

        /// <summary>
        /// Delcredere invoice (Code: 390)
        /// </summary>
        /// <remarks>
        /// An invoice sent to the party paying for a number of buyers.
        /// </remarks>
        DelcredereInvoice,

        /// <summary>
        /// Metering point information response (Code: 391)
        /// </summary>
        /// <remarks>
        /// Response to a request for information about a metering point.
        /// </remarks>
        MeteringPointInformationResponse,

        /// <summary>
        /// Notification of change of supplier (Code: 392)
        /// </summary>
        /// <remarks>
        /// A notification of a change of supplier.
        /// </remarks>
        NotificationOfChangeOfSupplier,

        /// <summary>
        /// Factored invoice (Code: 393)
        /// </summary>
        /// <remarks>
        /// Invoice assigned to a third party for collection.
        /// </remarks>
        FactoredInvoice,

        /// <summary>
        /// Lease invoice (Code: 394)
        /// </summary>
        /// <remarks>
        /// Usage of INVOIC-message for goods in leasing contracts.
        /// </remarks>
        LeaseInvoice,

        /// <summary>
        /// Consignment invoice (Code: 395)
        /// </summary>
        /// <remarks>
        /// Commercial invoice that covers a transaction other than one involving a sale.
        /// </remarks>
        ConsignmentInvoice,

        /// <summary>
        /// Factored credit note (Code: 396)
        /// </summary>
        /// <remarks>
        /// Credit note related to assigned invoice(s).
        /// </remarks>
        FactoredCreditNote,

        /// <summary>
        /// Commercial account summary response (Code: 397)
        /// </summary>
        /// <remarks>
        /// A document providing a response to a previously sent commercial account summary message.
        /// </remarks>
        CommercialAccountSummaryResponse,

        /// <summary>
        /// Cross docking despatch advice (Code: 398)
        /// </summary>
        /// <remarks>
        /// Document by means of which the supplier or consignor informs the buyer, consignee or the distribution centre about the despatch of goods for cross docking.
        /// </remarks>
        CrossDockingDespatchAdvice,

        /// <summary>
        /// Transshipment despatch advice (Code: 399)
        /// </summary>
        /// <remarks>
        /// Document by means of which the supplier or consignor informs the buyer, consignee or the distribution centre about the despatch of goods for transshipment.
        /// </remarks>
        TransshipmentDespatchAdvice,

        /// <summary>
        /// Exceptional order (Code: 400)
        /// </summary>
        /// <remarks>
        /// An order which falls outside the framework of an agreement.
        /// </remarks>
        ExceptionalOrder,

        /// <summary>
        /// Pre-packed cross docking order (Code: 401)
        /// </summary>
        /// <remarks>
        /// An order requesting the supply of products packed according to the final delivery point which will be moved across a dock in a distribution centre without further handling.
        /// </remarks>
        PrePackedCrossDockingOrder,

        /// <summary>
        /// Intermediate handling cross docking order (Code: 402)
        /// </summary>
        /// <remarks>
        /// An order requesting the supply of products which will be moved across a dock, de-consolidated and re-consolidated according to the final delivery location requirements.
        /// </remarks>
        IntermediateHandlingCrossDockingOrder,

        /// <summary>
        /// Means of transportation availability information (Code: 403)
        /// </summary>
        /// <remarks>
        /// Information giving the various availabilities of a means of transportation.
        /// </remarks>
        MeansOfTransportationAvailabilityInformation,

        /// <summary>
        /// Means of transportation schedule information (Code: 404)
        /// </summary>
        /// <remarks>
        /// Information giving the various schedules of a means of transportation.
        /// </remarks>
        MeansOfTransportationScheduleInformation,

        /// <summary>
        /// Transport equipment delivery notice (Code: 405)
        /// </summary>
        /// <remarks>
        /// Notification regarding the delivery of transport equipment.
        /// </remarks>
        TransportEquipmentDeliveryNotice,

        /// <summary>
        /// Notification to supplier of contract termination (Code: 406)
        /// </summary>
        /// <remarks>
        /// Notification to the supplier regarding the termination of a contract.
        /// </remarks>
        NotificationToSupplierOfContractTermination,

        /// <summary>
        /// Notification to supplier of metering point changes (Code: 407)
        /// </summary>
        /// <remarks>
        /// Notification to the supplier about changes regarding a metering point.
        /// </remarks>
        NotificationToSupplierOfMeteringPointChanges,

        /// <summary>
        /// Notification of meter change (Code: 408)
        /// </summary>
        /// <remarks>
        /// Notification about the change of a meter.
        /// </remarks>
        NotificationOfMeterChange,

        /// <summary>
        /// Instructions for bank transfer (Code: 409)
        /// </summary>
        /// <remarks>
        /// Document/message containing instructions from a customer to his bank to pay an amount in a specified currency to a nominated party in another country by a method either specified (e.g. teletransmission, air mail) or left to the discretion of the bank.
        /// </remarks>
        InstructionsForBankTransfer,

        /// <summary>
        /// Notification of metering point identification change (Code: 410)
        /// </summary>
        /// <remarks>
        /// Notification of the change of metering point identification.
        /// </remarks>
        NotificationOfMeteringPointIdentificationChange,

        /// <summary>
        /// Utilities time series message (Code: 411)
        /// </summary>
        /// <remarks>
        /// The Utilities time series message is sent between responsible parties in a utilities infrastructure for the purpose of reporting time series and connected technical and/or administrative information.
        /// </remarks>
        UtilitiesTimeSeriesMessage,

        /// <summary>
        /// Application for banker's draft (Code: 412)
        /// </summary>
        /// <remarks>
        /// Application by a customer to his bank to issue a banker's draft stating the amount and currency of the draft, the name of the payee and the place and country of payment.
        /// </remarks>
        ApplicationForBankersDraft,

        /// <summary>
        /// Infrastructure condition (Code: 413)
        /// </summary>
        /// <remarks>
        /// Information about components in an infrastructure.
        /// </remarks>
        InfrastructureCondition,

        /// <summary>
        /// Acknowledgement of change of supplier (Code: 414)
        /// </summary>
        /// <remarks>
        /// Acknowledgement of the change of supplier.
        /// </remarks>
        AcknowledgementOfChangeOfSupplier,

        /// <summary>
        /// Data Plot Sheet (Code: 415)
        /// </summary>
        /// <remarks>
        /// Document/Message providing technical description and information of the crop production.
        /// </remarks>
        DataPlotSheet,

        /// <summary>
        /// Soil analysis (Code: 416)
        /// </summary>
        /// <remarks>
        /// Soil analysis document.
        /// </remarks>
        SoilAnalysis,

        /// <summary>
        /// Farmyard manure analysis (Code: 417)
        /// </summary>
        /// <remarks>
        /// Farmyard manure analysis document.
        /// </remarks>
        FarmyardManureAnalysis,

        /// <summary>
        /// WCO Cargo Report Export, Rail or Road (Code: 418)
        /// </summary>
        /// <remarks>
        /// Declaration, in accordance with the WCO Customs Data Model, to Customs concerning the export of cargo carried by commercial means of transport over land, e.g. truck or train.
        /// </remarks>
        WCOCargoReportExportRailOrRoad,

        /// <summary>
        /// WCO Cargo Report Export, Air or Maritime (Code: 419)
        /// </summary>
        /// <remarks>
        /// Declaration, in accordance with the WCO Customs Data Model, to Customs concerning the export of cargo carried by commercial means of transport over water or through the air, e.g. vessel or aircraft.
        /// </remarks>
        WCOCargoReportExportAirOrMaritime,

        /// <summary>
        /// Optical Character Reading (OCR) payment credit note (Code: 420)
        /// </summary>
        /// <remarks>
        /// Payment credit note effected by an Optical Character Reading (OCR) document.
        /// </remarks>
        OpticalCharacterReadingOCRPaymentCreditNote,

        /// <summary>
        /// WCO Cargo Report Import, Rail or Road (Code: 421)
        /// </summary>
        /// <remarks>
        /// Declaration, in accordance with the WCO Customs Data Model, to Customs concerning the import of cargo carried by commercial means of transport over land, e.g. truck or train.
        /// </remarks>
        WCOCargoReportImportRailOrRoad,

        /// <summary>
        /// WCO Cargo Report Import, Air or Maritime (Code: 422)
        /// </summary>
        /// <remarks>
        /// Declaration, in accordance with the WCO Customs Data Model, to Customs concerning the import of cargo carried by commercial means of transport over water or through the air, e.g. vessel or aircraft.
        /// </remarks>
        WCOCargoReportImportAirOrMaritime,

        /// <summary>
        /// WCO one-step export declaration (Code: 423)
        /// </summary>
        /// <remarks>
        /// Single step declaration, in accordance with the WCO Customs Data Model, to Customs by which goods are declared for a Customs export procedure based on the
        /// </remarks>
        WCOOneStepExportDeclaration,

        /// <summary>
        /// Kyoto Convention. (Code: 1999)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        KyotoConvention,

        /// <summary>
        /// WCO first step of two-step export declaration (Code: 424)
        /// </summary>
        /// <remarks>
        /// First part of a simplified declaration, in accordance with the WCO Customs Data Model, to Customs by which goods are declared for Customs export procedure based on the 1999 Kyoto Convention.
        /// </remarks>
        WCOFirstStepOfTwoStepExportDeclaration,

        /// <summary>
        /// Collection payment advice (Code: 425)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank advises that a collection has been paid, giving details and methods of funds disposal.
        /// </remarks>
        CollectionPaymentAdvice,

        /// <summary>
        /// Documentary credit payment advice (Code: 426)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank advises payment under a documentary credit.
        /// </remarks>
        DocumentaryCreditPaymentAdvice,

        /// <summary>
        /// Documentary credit acceptance advice (Code: 427)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank advises acceptance under a documentary credit.
        /// </remarks>
        DocumentaryCreditAcceptanceAdvice,

        /// <summary>
        /// Documentary credit negotiation advice (Code: 428)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank advises negotiation under a documentary credit.
        /// </remarks>
        DocumentaryCreditNegotiationAdvice,

        /// <summary>
        /// Application for banker's guarantee (Code: 429)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a customer requests his bank to issue a guarantee in favour of a nominated party in another country, stating the amount and currency and the specific conditions of the guarantee.
        /// </remarks>
        ApplicationForBankersGuarantee,

        /// <summary>
        /// Banker's guarantee (Code: 430)
        /// </summary>
        /// <remarks>
        /// Document/message in which a bank undertakes to pay out a limited amount of money to a designated party, on conditions stated therein (other than those laid down in the Uniform Customs Practice).
        /// </remarks>
        BankersGuarantee,

        /// <summary>
        /// Documentary credit letter of indemnity (Code: 431)
        /// </summary>
        /// <remarks>
        /// Document/message in which a beneficiary of a documentary credit accepts responsibility for non-compliance with the terms and conditions of the credit, and undertakes to refund the money received under the credit, with interest and charges accrued.
        /// </remarks>
        DocumentaryCreditLetterOfIndemnity,

        /// <summary>
        /// Notification to grid operator of contract termination (Code: 432)
        /// </summary>
        /// <remarks>
        /// Notification to the grid operator regarding the termination of a contract.
        /// </remarks>
        NotificationToGridOperatorOfContractTermination,

        /// <summary>
        /// Notification to grid operator of metering point changes (Code: 433)
        /// </summary>
        /// <remarks>
        /// Notification to the grid operator about changes regarding a metering point.
        /// </remarks>
        NotificationToGridOperatorOfMeteringPointChanges,

        /// <summary>
        /// Notification of balance responsible entity change (Code: 434)
        /// </summary>
        /// <remarks>
        /// Notification of a change of balance responsible entity.
        /// </remarks>
        NotificationOfBalanceResponsibleEntityChange,

        /// <summary>
        /// Preadvice of a credit (Code: 435)
        /// </summary>
        /// <remarks>
        /// Preadvice indicating a credit to happen in the future.
        /// </remarks>
        PreadviceOfACredit,

        /// <summary>
        /// Transport equipment profile report (Code: 436)
        /// </summary>
        /// <remarks>
        /// Report on the profile of transport equipment.
        /// </remarks>
        TransportEquipmentProfileReport,

        /// <summary>
        /// Request for price and delivery quote, specified end-user (Code: 437)
        /// </summary>
        /// <remarks>
        /// Document/message requesting price conditions and delivery conditions under which goods are offered, provided that they are sold to the end-customer specified on the request for quote.
        /// </remarks>
        RequestForPriceAndDeliveryQuotespecifiedEndUser,

        /// <summary>
        /// Request for price quote, ship and debit (Code: 438)
        /// </summary>
        /// <remarks>
        /// Document/message from a distributor to a supplier requesting price conditions under which goods can be sold by the distributor to the end-customer specified on the request for quote with compensation for loss of inventory value.
        /// </remarks>
        RequestForPriceQuoteshipAndDebit,

        /// <summary>
        /// Request for price and delivery quote, ship and debit (Code: 439)
        /// </summary>
        /// <remarks>
        /// Document/message from a distributor to a supplier requesting price conditions and delivery conditions under which goods can be sold by the distributor to the end-customer specified on the request for quote with compensation for loss of inventory value.
        /// </remarks>
        RequestForPriceAndDeliveryQuoteshipAndDebit,

        /// <summary>
        /// Delivery point list. (Code: 440)
        /// </summary>
        /// <remarks>
        /// A list of delivery point addresses.
        /// </remarks>
        DeliveryPointList,

        /// <summary>
        /// Transport routing information (Code: 441)
        /// </summary>
        /// <remarks>
        /// Document specifying the routes for transport between locations.
        /// </remarks>
        TransportRoutingInformation,

        /// <summary>
        /// Request for delivery quote (Code: 442)
        /// </summary>
        /// <remarks>
        /// Document/message requesting delivery conditions under which goods are offered.
        /// </remarks>
        RequestForDeliveryQuote,

        /// <summary>
        /// Request for price and delivery quote (Code: 443)
        /// </summary>
        /// <remarks>
        /// Document/message requesting price and delivery conditions under which goods are offered.
        /// </remarks>
        RequestForPriceAndDeliveryQuote,

        /// <summary>
        /// Request for contract price quote (Code: 444)
        /// </summary>
        /// <remarks>
        /// Document/message requesting contractual price conditions under which goods are offered.
        /// </remarks>
        RequestForContractPriceQuote,

        /// <summary>
        /// Request for contract price and delivery quote (Code: 445)
        /// </summary>
        /// <remarks>
        /// Document/message requesting contractual price conditions and contractual delivery conditions under which goods are offered.
        /// </remarks>
        RequestForContractPriceAndDeliveryQuote,

        /// <summary>
        /// Request for price quote, specified end-customer (Code: 446)
        /// </summary>
        /// <remarks>
        /// Document/message requesting price conditions under which goods are offered, provided that they are sold to the end-customer specified on the request for quote.
        /// </remarks>
        RequestForPriceQuotespecifiedEndCustomer,

        /// <summary>
        /// Collection order (Code: 447)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank is instructed (or requested) to handle financial and/or commercial documents in order to obtain acceptance and/or payment, or to deliver documents on such other terms and conditions as may be specified.
        /// </remarks>
        CollectionOrder,

        /// <summary>
        /// Documents presentation form (Code: 448)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a draft or similar instrument and/or commercial documents are presented to a bank for acceptance, discounting, negotiation, payment or collection, whether or not against a documentary credit.
        /// </remarks>
        DocumentsPresentationForm,

        /// <summary>
        /// Identification match (Code: 449)
        /// </summary>
        /// <remarks>
        /// Message related to conducting a search for an identification match.
        /// </remarks>
        IdentificationMatch,

        /// <summary>
        /// Payment order (Code: 450)
        /// </summary>
        /// <remarks>
        /// Document/message containing information needed to initiate the payment. It may cover the financial settlement for one or more commercial trade transactions. A payment order is an instruction to the ordered bank to arrange for the payment of one specified amount to the beneficiary.
        /// </remarks>
        PaymentOrder,

        /// <summary>
        /// Extended payment order (Code: 451)
        /// </summary>
        /// <remarks>
        /// Document/message containing information needed to initiate the payment. It may cover the financial settlement for several commercial trade transactions, which it is possible to specify in a special payments detail part. It is an instruction to the ordered bank to arrange for the payment of one specified amount to the beneficiary.
        /// </remarks>
        ExtendedPaymentOrder,

        /// <summary>
        /// Multiple payment order (Code: 452)
        /// </summary>
        /// <remarks>
        /// Document/message containing a payment order to debit one or more accounts and to credit one or more beneficiaries.
        /// </remarks>
        MultiplePaymentOrder,

        /// <summary>
        /// Notice that circumstances prevent payment of delivered (Code: 453)
        /// </summary>
        /// <remarks>
        /// goods Message used to inform a supplier that delivered goods cannot be paid due to circumstances which prevent payment.
        /// </remarks>
        NoticeThatCircumstancesPreventPaymentOfDelivered,

        /// <summary>
        /// Credit advice (Code: 454)
        /// </summary>
        /// <remarks>
        /// Document/message sent by an account servicing institution to one of its account owners, to inform the account owner of an entry which has been or will be credited to its account for a specified amount on the date indicated.
        /// </remarks>
        CreditAdvice,

        /// <summary>
        /// Extended credit advice (Code: 455)
        /// </summary>
        /// <remarks>
        /// Document/message sent by an account servicing institution to one of its account owners, to inform the account owner of an entry that has been or will be credited to its account for a specified amount on the date indicated. It provides extended commercial information concerning the relevant remittance advice.
        /// </remarks>
        ExtendedCreditAdvice,

        /// <summary>
        /// Debit advice (Code: 456)
        /// </summary>
        /// <remarks>
        /// Advice on a debit.
        /// </remarks>
        DebitAdvice,

        /// <summary>
        /// Reversal of debit (Code: 457)
        /// </summary>
        /// <remarks>
        /// Reversal of debit accounting entry by bank.
        /// </remarks>
        ReversalOfDebit,

        /// <summary>
        /// Reversal of credit (Code: 458)
        /// </summary>
        /// <remarks>
        /// Reversal of credit accounting entry by bank.
        /// </remarks>
        ReversalOfCredit,

        /// <summary>
        /// Travel ticket (Code: 459)
        /// </summary>
        /// <remarks>
        /// The document is a ticket giving access to a travel service.
        /// </remarks>
        TravelTicket,

        /// <summary>
        /// Documentary credit application (Code: 460)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank is requested to issue a documentary credit on the conditions specified therein.
        /// </remarks>
        DocumentaryCreditApplication,

        /// <summary>
        /// Payment card (Code: 461)
        /// </summary>
        /// <remarks>
        /// The document is a credit, guarantee or charge card.
        /// </remarks>
        PaymentCard,

        /// <summary>
        /// Ready for transshipment despatch advice (Code: 462)
        /// </summary>
        /// <remarks>
        /// Document to advise that the goods ordered are ready for transshipment.
        /// </remarks>
        ReadyForTransshipmentDespatchAdvice,

        /// <summary>
        /// Pre-packed cross docking despatch advice (Code: 463)
        /// </summary>
        /// <remarks>
        /// Document by means of which the supplier or consignor informs the buyer, consignee or distribution centre about the despatch of products packed according to the final delivery point requirements which will be moved across a dock in a distribution centre without further handling.
        /// </remarks>
        PrePackedCrossDockingDespatchAdvice,

        /// <summary>
        /// Intermediate handling cross docking despatch advice (Code: 464)
        /// </summary>
        /// <remarks>
        /// Document by means of which the supplier or consignor informs the buyer, consignee or the distribution centre about the despatch of products which will be moved across a dock, de-consolidated and re-consolidated according to final delivery location requirements.
        /// </remarks>
        IntermediateHandlingCrossDockingDespatchAdvice,

        /// <summary>
        /// Documentary credit (Code: 465)
        /// </summary>
        /// <remarks>
        /// Document/message in which a bank states that it has issued a documentary credit under which the beneficiary is to obtain payment, acceptance or negotiation on compliance with certain terms and conditions and against presentation of stipulated documents and such drafts as may be specified. The credit may or may not be confirmed by another bank.
        /// </remarks>
        DocumentaryCredit,

        /// <summary>
        /// Documentary credit notification (Code: 466)
        /// </summary>
        /// <remarks>
        /// Document/message issued by an advising bank in order to transmit a documentary credit to a beneficiary, or to another advising bank.
        /// </remarks>
        DocumentaryCreditNotification,

        /// <summary>
        /// Documentary credit transfer advice (Code: 467)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank advises that (part of) a documentary credit is being or has been transferred in favour of a second beneficiary.
        /// </remarks>
        DocumentaryCreditTransferAdvice,

        /// <summary>
        /// Documentary credit amendment notification (Code: 468)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank advises that the terms and conditions of a documentary credit have been amended.
        /// </remarks>
        DocumentaryCreditAmendmentNotification,

        /// <summary>
        /// Documentary credit amendment (Code: 469)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a bank notifies a beneficiary of the details of an amendment to the terms and conditions of a documentary credit.
        /// </remarks>
        DocumentaryCreditAmendment,

        /// <summary>
        /// Waste disposal report (Code: 470)
        /// </summary>
        /// <remarks>
        /// Document/message sent by a shipping agent to an authority for reporting information on waste disposal.
        /// </remarks>
        WasteDisposalReport,

        /// <summary>
        /// Remittance advice (Code: 481)
        /// </summary>
        /// <remarks>
        /// Document/message advising of the remittance of payment.
        /// </remarks>
        RemittanceAdvice,

        /// <summary>
        /// Port authority waste disposal report (Code: 482)
        /// </summary>
        /// <remarks>
        /// Document/message sent by a port authority to another port authority for reporting information on waste disposal.
        /// </remarks>
        PortAuthorityWasteDisposalReport,

        /// <summary>
        /// Visa (Code: 483)
        /// </summary>
        /// <remarks>
        /// An endorsement on a passport or any other recognised travel document indicating that it has been examined and found correct, especially as permitting the holder to enter or leave a country.
        /// </remarks>
        Visa,

        /// <summary>
        /// Multiple direct debit request (Code: 484)
        /// </summary>
        /// <remarks>
        /// Document/message containing a direct debit request to credit one or more accounts and to debit one or more debtors.
        /// </remarks>
        MultipleDirectDebitRequest,

        /// <summary>
        /// Banker's draft (Code: 485)
        /// </summary>
        /// <remarks>
        /// Draft drawn in favour of a third party either by one bank on another bank, or by a branch of a bank on its head office (or vice versa) or upon another branch of the same bank. In either case, the draft should comply with the specifications laid down for cheques in the country in which it is to be payable.
        /// </remarks>
        BankersDraft,

        /// <summary>
        /// Multiple direct debit (Code: 486)
        /// </summary>
        /// <remarks>
        /// Document/message containing a direct debit to credit one or more accounts and to debit one or more debtors.
        /// </remarks>
        MultipleDirectDebit,

        /// <summary>
        /// Certificate of disembarkation permission (Code: 487)
        /// </summary>
        /// <remarks>
        /// Document or message issuing permission to disembark.
        /// </remarks>
        CertificateOfDisembarkationPermission,

        /// <summary>
        /// Deratting exemption certificate (Code: 488)
        /// </summary>
        /// <remarks>
        /// Document certifying that the object was free of rats when inspected and that it is exempt from a deratting statement.
        /// </remarks>
        DerattingExemptionCertificate,

        /// <summary>
        /// Reefer connection order (Code: 489)
        /// </summary>
        /// <remarks>
        /// Order to connect a reefer container to a reefer point.
        /// </remarks>
        ReeferConnectionOrder,

        /// <summary>
        /// Bill of exchange (Code: 490)
        /// </summary>
        /// <remarks>
        /// Document/message, issued and signed in conformity with the applicable legislation, which contains an unconditional order whereby the drawer directs the drawee to pay a definite sum of money to the payee or to his order, on demand or at a definite time, against the surrender of the document itself.
        /// </remarks>
        BillOfExchange,

        /// <summary>
        /// Promissory note (Code: 491)
        /// </summary>
        /// <remarks>
        /// Document/message, issued and signed in conformity with the applicable legislation, which contains an unconditional promise whereby the maker undertakes to pay a definite sum of money to the payee or to his order, on demand or at a definite time, against the surrender of the document itself.
        /// </remarks>
        PromissoryNote,

        /// <summary>
        /// Statement of account message (Code: 493)
        /// </summary>
        /// <remarks>
        /// Usage of STATAC-message.
        /// </remarks>
        StatementOfAccountMessage,

        /// <summary>
        /// Direct delivery (transport) (Code: 494)
        /// </summary>
        /// <remarks>
        /// Document/message ordering the direct delivery of goods/consignment from one means of transport into another means of transport in one movement.
        /// </remarks>
        DirectDeliveryTransport,

        /// <summary>
        /// WCO second step of two-step export declaration (Code: 495)
        /// </summary>
        /// <remarks>
        /// Second part of a simplified declaration, in accordance with the WCO Customs Data Model, to Customs by which goods are declared for Customs export procedure based on the 1999 Kyoto Convention.
        /// </remarks>
        WCOSecondStepOfTwoStepExportDeclaration,

        /// <summary>
        /// WCO one-step import declaration (Code: 496)
        /// </summary>
        /// <remarks>
        /// Single step declaration, in accordance with the WCO Customs Data Model, to Customs by which goods are declared for Customs import procedure based on the 1999 Kyoto Convention.
        /// </remarks>
        WCOOneStepImportDeclaration,

        /// <summary>
        /// WCO first step of two-step import declaration (Code: 497)
        /// </summary>
        /// <remarks>
        /// First part of a simplified declaration, in accordance with the WCO Customs Data Model, to Customs by which goods are declared for Customs import procedure based on the 1999 Kyoto Convention.
        /// </remarks>
        WCOFirstStepOfTwoStepImportDeclaration,

        /// <summary>
        /// WCO second step of two-step import declaration (Code: 498)
        /// </summary>
        /// <remarks>
        /// Second part of a simplified declaration, in accordance with the WCO Customs Data Model, to Customs by which goods are declared for Customs import procedure based on the 1999 Kyoto Convention.
        /// </remarks>
        WCOSecondStepOfTwoStepImportDeclaration,

        /// <summary>
        /// Previous transport document (Code: 499)
        /// </summary>
        /// <remarks>
        /// Identification of the previous transport document.
        /// </remarks>
        PreviousTransportDocument,

        /// <summary>
        /// Insurance certificate (Code: 520)
        /// </summary>
        /// <remarks>
        /// Document/message issued to the insured certifying that insurance has been effected and that a policy has been issued. Such a certificate for a particular cargo is primarily used when good are insured under the terms of a floating or an open policy; at the request of the insured it can be exchanged for a policy.
        /// </remarks>
        InsuranceCertificate,

        /// <summary>
        /// Special requirements permit related to the transport of (Code: 521)
        /// </summary>
        /// <remarks>
        /// cargo A permit related to a transport document granting the transport of cargo under the conditions as specifically required.
        /// </remarks>
        SpecialRequirementsPermitRelatedToTheTransportOf,

        /// <summary>
        /// Dangerous Goods Notification for Tanker vessel (Code: 522)
        /// </summary>
        /// <remarks>
        /// Dangerous Goods Notification for a vessel carrying liquid cargo in bulk.
        /// </remarks>
        DangerousGoodsNotificationForTankerVessel,

        /// <summary>
        /// Dangerous Goods Notification for non-tanker vessel (Code: 523)
        /// </summary>
        /// <remarks>
        /// Dangerous Goods Notification for a vessel carrying cargo other than bulk liquid cargo.
        /// </remarks>
        DangerousGoodsNotificationForNonTankerVessel,

        /// <summary>
        /// WCO Conveyance Arrival Report (Code: 524)
        /// </summary>
        /// <remarks>
        /// Declaration, in accordance with the WCO Customs Data Model, to Customs regarding the conveyance arriving in a Customs territory.
        /// </remarks>
        WCOConveyanceArrivalReport,

        /// <summary>
        /// WCO Conveyance Departure Report (Code: 525)
        /// </summary>
        /// <remarks>
        /// Declaration, in accordance with the WCO Customs Data Model, to Customs regarding the conveyance departing a Customs territory.
        /// </remarks>
        WCOConveyanceDepartureReport,

        /// <summary>
        /// Accounting voucher (Code: 526)
        /// </summary>
        /// <remarks>
        /// A document/message justifying an accounting entry.
        /// </remarks>
        AccountingVoucher,

        /// <summary>
        /// Self billed debit note (Code: 527)
        /// </summary>
        /// <remarks>
        /// A document which indicates that the customer is claiming debit in a self billing environment.
        /// </remarks>
        SelfBilledDebitNote,

        /// <summary>
        /// Military Identification Card (Code: 528)
        /// </summary>
        /// <remarks>
        /// The official document used for military personnel on travel orders, substituting a passport.
        /// </remarks>
        MilitaryIdentificationCard,

        /// <summary>
        /// Re-Entry Permit (Code: 529)
        /// </summary>
        /// <remarks>
        /// A permit to re-enter a country.
        /// </remarks>
        ReEntryPermit,

        /// <summary>
        /// Insurance policy (Code: 530)
        /// </summary>
        /// <remarks>
        /// Document/message issued by the insurer evidencing an agreement to insure and containing the conditions of the agreement concluded whereby the insurer undertakes for a specific fee to indemnify the insured for the losses arising out of the perils and accidents specified in the contract.
        /// </remarks>
        InsurancePolicy,

        /// <summary>
        /// Refugee Permit (Code: 531)
        /// </summary>
        /// <remarks>
        /// Document identifying a refugee recognized by a country.
        /// </remarks>
        RefugeePermit,

        /// <summary>
        /// Forwarder�s credit note (Code: 532)
        /// </summary>
        /// <remarks>
        /// Document/message for providing credit information to the relevant party.
        /// </remarks>
        ForwardersCreditNote,

        /// <summary>
        /// Original accounting voucher (Code: 533)
        /// </summary>
        /// <remarks>
        /// To indicate that the document/message justifying an accounting entry is original.
        /// </remarks>
        OriginalAccountingVoucher,

        /// <summary>
        /// Copy accounting voucher (Code: 534)
        /// </summary>
        /// <remarks>
        /// To indicate that the document/message justifying an accounting entry is a copy.
        /// </remarks>
        CopyAccountingVoucher,

        /// <summary>
        /// Pro-forma accounting voucher (Code: 535)
        /// </summary>
        /// <remarks>
        /// To indicate that the document/message justifying an accounting entry is pro-forma.
        /// </remarks>
        ProFormaAccountingVoucher,

        /// <summary>
        /// International Ship Security Certificate (Code: 536)
        /// </summary>
        /// <remarks>
        /// A certificate on ship security issued based on the International code for the Security of Ships and of Port facilities (ISPS code).
        /// </remarks>
        InternationalShipSecurityCertificate,

        /// <summary>
        /// Interim International Ship Security Certificate (Code: 537)
        /// </summary>
        /// <remarks>
        /// An interim certificate on ship security issued basis under the International code for the Security of Ships and of Port facilities (ISPS code).
        /// </remarks>
        InterimInternationalShipSecurityCertificate,

        /// <summary>
        /// Good Manufacturing Practice (GMP) Certificate (Code: 538)
        /// </summary>
        /// <remarks>
        /// Certificate that guarantees quality manufacturing and processing of food products, medications, cosmetics, etc.
        /// </remarks>
        GoodManufacturingPracticeGMPCertificate,

        /// <summary>
        /// Framework Agreement (Code: 539)
        /// </summary>
        /// <remarks>
        /// An agreement between one or more contracting authorities and one or more economic operators, the purpose of which is to establish the terms governing contracts to be awarded during a given period, in particular with regard to price and, where appropriate, the quantity envisaged.
        /// </remarks>
        FrameworkAgreement,

        /// <summary>
        /// Insurance declaration sheet (bordereau) (Code: 550)
        /// </summary>
        /// <remarks>
        /// A document/message used when an insured reports to his insurer details of individual shipments which are covered by an insurance contract - an open cover or a floating policy - between the parties.
        /// </remarks>
        InsuranceDeclarationSheetBordereau,

        /// <summary>
        /// Transport capacity offer (Code: 551)
        /// </summary>
        /// <remarks>
        /// Offering of capacity for the transport of goods for a date and a route.
        /// </remarks>
        TransportCapacityOffer,

        /// <summary>
        /// Ship Security Plan (Code: 552)
        /// </summary>
        /// <remarks>
        /// Ship Security Plan (SSP) is a document prepared in terms of the ISPS Code to contribute to the prevention of illegal acts against the ship and its crew.
        /// </remarks>
        ShipSecurityPlan,

        /// <summary>
        /// Forwarder�s invoice discrepancy report (Code: 553)
        /// </summary>
        /// <remarks>
        /// Document/message reporting invoice discrepancies indentified by the forwarder.
        /// </remarks>
        ForwardersInvoiceDiscrepancyReport,

        /// <summary>
        /// Storage capacity offer (Code: 554)
        /// </summary>
        /// <remarks>
        /// Offering of capacity to store goods.
        /// </remarks>
        StorageCapacityOffer,

        /// <summary>
        /// Insurer's invoice (Code: 575)
        /// </summary>
        /// <remarks>
        /// Document/message issued by an insurer specifying the cost of an insurance which has been effected and claiming payment therefore.
        /// </remarks>
        InsurersInvoice,

        /// <summary>
        /// Storage capacity request (Code: 576)
        /// </summary>
        /// <remarks>
        /// Request for capacity to store goods.
        /// </remarks>
        StorageCapacityRequest,

        /// <summary>
        /// Transport capacity request (Code: 577)
        /// </summary>
        /// <remarks>
        /// Request for capacity for the transport of goods for a date and a route.
        /// </remarks>
        TransportCapacityRequest,

        /// <summary>
        /// EU Customs declaration for External Community Transit (T1) (Code: 578)
        /// </summary>
        /// <remarks>
        /// Customs declaration for goods under the external Community/common transit procedure. This applies to "non-Community goods" ("T1" under EU legislation and EC- EFTA "Transit Convention").
        /// </remarks>
        EUCustomsDeclarationForExternalCommunityTransitT1,

        /// <summary>
        /// EU Customs declaration for internal Community Transit (T2) (Code: 579)
        /// </summary>
        /// <remarks>
        /// Customs declaration for goods under the internal Community/common transit procedure. This applies to "Community goods" ("T2" under EU legislation and EC-EFTA "Transit Convention").
        /// </remarks>
        EUCustomsDeclarationForInternalCommunityTransitT2,

        /// <summary>
        /// Cover note (Code: 580)
        /// </summary>
        /// <remarks>
        /// Document/message issued by an insurer (insurance broker, agent, etc.) to notify the insured that his insurance have been carried out.
        /// </remarks>
        CoverNote,

        /// <summary>
        /// EU Customs declaration for non-fiscal area internal (Code: 581)
        /// </summary>
        /// <remarks>
        /// Community Transit (T2F) Declaration for goods under the internal Community transit procedure in the context of trade between the "VAT" territory of EU Member States and EU territories where the VAT rules do not apply, such as Canary islands, some French overseas territories, the Channel islands and the Aaland islands, and between those territories. ("T2F" under EU Legislation).
        /// </remarks>
        EUCustomsDeclarationForNonFiscalAreaInternal,

        /// <summary>
        /// EU Customs declaration for internal transit to San Marino (Code: 582)
        /// </summary>
        /// <remarks>
        /// (T2SM) Customs declaration for goods under the internal Community transit procedure between the Community and San Marino. ("T2SM" under EU Legislation).
        /// </remarks>
        EUCustomsDeclarationForInternalTransitToSanMarino,

        /// <summary>
        /// EU Customs declaration for mixed consignments (T) (Code: 583)
        /// </summary>
        /// <remarks>
        /// Customs declaration for goods under the Community/common transit procedure for mixed consignments (i.e. consignments that comprise goods of different statuses, like "T1" and "T2") ("T" under EU Legislation).
        /// </remarks>
        EUCustomsDeclarationForMixedConsignmentsT,

        /// <summary>
        /// EU Document for establishing the Community status of goods (Code: 584)
        /// </summary>
        /// <remarks>
        /// (T2L) Form establishing the Community status of goods ("T2L" under EU Legislation).
        /// </remarks>
        EUDocumentForEstablishingTheCommunityStatusOfGoods,

        /// <summary>
        /// EU Document for establishing the Community status of goods (Code: 585)
        /// </summary>
        /// <remarks>
        /// for certain fiscal purposes (T2LF) Form establishing the Community status of goods in the context of trade between the "VAT" territory of EU Member States and EU territories where the VAT rules do not apply, such as Canary islands, some French overseas territories, the Channel islands and the Aaland islands, and between those territories ("T2LF" under EU Legislation).
        /// </remarks>
        EUDocumentForEstablishingTheCommunityStatusOfGoodsForCertainFiscalPurposes,

        /// <summary>
        /// Document for establishing the Customs Status of goods for (Code: 586)
        /// </summary>
        /// <remarks>
        /// San Marino (T2LSM) Form establishing the Community status of goods ("T2L" under European Legislation) in the context of trade between the EU and San Marino. ("T2LSM" under EU Legislation).
        /// </remarks>
        DocumentForEstablishingTheCustomsStatusOfGoodsFor,

        /// <summary>
        /// Customs declaration for TIR Carnet goods (Code: 587)
        /// </summary>
        /// <remarks>
        /// A Customs declaration in which goods move under cover of TIR Carnets.
        /// </remarks>
        CustomsDeclarationForTIRCarnetGoods,

        /// <summary>
        /// Transport Means Security Report (Code: 588)
        /// </summary>
        /// <remarks>
        /// A document reporting the security status and related information of a means of transport.
        /// </remarks>
        TransportMeansSecurityReport,

        /// <summary>
        /// Halal Slaughtering Certificate (Code: 589)
        /// </summary>
        /// <remarks>
        /// A certificate verifying that meat has been produced from slaughter in accordance with Islamic laws and practices.
        /// </remarks>
        HalalSlaughteringCertificate,

        /// <summary>
        /// Forwarding instructions (Code: 610)
        /// </summary>
        /// <remarks>
        /// Document/message issued to a freight forwarder, giving instructions regarding the action to be taken by the forwarder for the forwarding of goods described therein.
        /// </remarks>
        ForwardingInstructions,

        /// <summary>
        /// Forwarder's advice to import agent (Code: 621)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a freight forwarder in an exporting country advising his counterpart in an importing country about the forwarding of goods described therein.
        /// </remarks>
        ForwardersAdviceToImportAgent,

        /// <summary>
        /// Forwarder's advice to exporter (Code: 622)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a freight forwarder informing an exporter of the action taken in fulfillment of instructions received.
        /// </remarks>
        ForwardersAdviceToExporter,

        /// <summary>
        /// Forwarder's invoice (Code: 623)
        /// </summary>
        /// <remarks>
        /// Invoice issued by a freight forwarder specifying services rendered and costs incurred and claiming payment therefore.
        /// </remarks>
        ForwardersInvoice,

        /// <summary>
        /// Forwarder's certificate of receipt (Code: 624)
        /// </summary>
        /// <remarks>
        /// Non-negotiable document issued by a forwarder to certify that he has assumed control of a specified consignment, with irrevocable instructions to send it to the consignee indicated in the document or to hold it at his disposal. E.g. FIATA-FCR.
        /// </remarks>
        ForwardersCertificateOfReceipt,

        /// <summary>
        /// Heat Treatment Certificate (Code: 625)
        /// </summary>
        /// <remarks>
        /// A certificate verifying the heat treatment of the product is in conformance with international standards to ensure the product�s healthiness and/or shows the mode of heat treatment indicating the temperature and the amount of time the product or raw material used in the product was treated (such as milk).
        /// </remarks>
        HeatTreatmentCertificate,

        /// <summary>
        /// Convention on International Trade in Endangered Species of (Code: 626)
        /// </summary>
        /// <remarks>
        /// Wild Fauna and Flora (CITES) Certificate A certificate used in the trade of endangered species in accordance with the CITES convention.
        /// </remarks>
        ConventionOnInternationalTradeInEndangeredSpeciesOf,

        /// <summary>
        /// Free Sale Certificate in the Country of Origin (Code: 627)
        /// </summary>
        /// <remarks>
        /// A certificate confirming that a specified product is free for sale in the country of origin.
        /// </remarks>
        FreeSaleCertificateInTheCountryOfOrigin,

        /// <summary>
        /// Transit license (Code: 628)
        /// </summary>
        /// <remarks>
        /// Document/message issued by the competent body in accordance with transit regulations in force, by which authorization is granted to a party to move articles under customs procedure.
        /// </remarks>
        TransitLicense,

        /// <summary>
        /// Veterinary quarantine certificate (Code: 629)
        /// </summary>
        /// <remarks>
        /// A certification that livestock or animal products, that are either imported or entering free zones, are kept under health supervision for a time period determined by veterinary quarantine instructions.
        /// </remarks>
        VeterinaryQuarantineCertificate,

        /// <summary>
        /// Shipping note (Code: 630)
        /// </summary>
        /// <remarks>
        /// (1123) Document/message provided by the shipper or his agent to the carrier, multimodal transport operator, terminal or other receiving authority, giving information about export consignments offered for transport, and providing for the necessary receipts and declarations of liability. Sometimes a multipurpose cargo handling document also fulfilling the functions of document 632, 633, 650 and 655.
        /// </remarks>
        ShippingNote,

        /// <summary>
        /// Forwarder's warehouse receipt (Code: 631)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a forwarder acting as Warehouse Keeper acknowledging receipt of goods placed in a warehouse, and stating or referring to the conditions which govern the warehousing and the release of goods. The document contains detailed provisions regarding the rights of holders-by-endorsement, transfer of ownership, etc. E.g. FIATA-FWR.
        /// </remarks>
        ForwardersWarehouseReceipt,

        /// <summary>
        /// Goods receipt (Code: 632)
        /// </summary>
        /// <remarks>
        /// Document/message to acknowledge the receipt of goods and in addition may indicate receiving conditions.
        /// </remarks>
        GoodsReceipt,

        /// <summary>
        /// Port charges documents (Code: 633)
        /// </summary>
        /// <remarks>
        /// Documents/messages specifying services rendered, storage and handling costs, demurrage and other charges due to the owner of goods described therein.
        /// </remarks>
        PortChargesDocuments,

        /// <summary>
        /// Certified list of ingredients (Code: 634)
        /// </summary>
        /// <remarks>
        /// A document legalized from a competent authority that shows the components of the product (food additive, detergent, disinfectant and sanitizer).
        /// </remarks>
        CertifiedListOfIngredients,

        /// <summary>
        /// Warehouse warrant (Code: 635)
        /// </summary>
        /// <remarks>
        /// Negotiable receipt document, issued by a Warehouse Keeper to a person placing goods in a warehouse and conferring title to the goods stored.
        /// </remarks>
        WarehouseWarrant,

        /// <summary>
        /// Health certificate (Code: 636)
        /// </summary>
        /// <remarks>
        /// A document legalized from a competent authority that shows that the product has been tested microbiologically and is free from any pathogens and fit for human consumption and/or declares that the product is in compliance with sanitary and phytosanitary measures.
        /// </remarks>
        HealthCertificate,

        /// <summary>
        /// Food grade certificate (Code: 637)
        /// </summary>
        /// <remarks>
        /// A document that shows that the product (food additive, detergent, disinfectant and sanitizer) is suitable to be used in the food industry.
        /// </remarks>
        FoodGradeCertificate,

        /// <summary>
        /// Certificate of suitability for transport of grains and (Code: 638)
        /// </summary>
        /// <remarks>
        /// legumes Certificate of inspection for the vessel stating its readiness and suitability for transporting grains and legumes.
        /// </remarks>
        CertificateOfSuitabilityForTransportOfGrainsAnd,

        /// <summary>
        /// Certificate of refrigerated transport equipment inspection (Code: 639)
        /// </summary>
        /// <remarks>
        /// Inspection document shows that the container, the cooling devices and measured temperature is in good working condition.
        /// </remarks>
        CertificateOfRefrigeratedTransportEquipmentInspection,

        /// <summary>
        /// Delivery order (Code: 640)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a party entitled to authorize the release of goods specified therein to a named consignee, to be retained by the custodian of the goods.
        /// </remarks>
        DeliveryOrder,

        /// <summary>
        /// Thermographic reading report (Code: 641)
        /// </summary>
        /// <remarks>
        /// A report of temperature readings over a period.
        /// </remarks>
        ThermographicReadingReport,

        /// <summary>
        /// Certificate of food item transport readiness (Code: 642)
        /// </summary>
        /// <remarks>
        /// A certificate to verify readiness of a transport or transport area such as a reservoir or hold to transport food items.
        /// </remarks>
        CertificateOfFoodItemTransportReadiness,

        /// <summary>
        /// Food packaging contact certificate (Code: 643)
        /// </summary>
        /// <remarks>
        /// A document legalized from a competent authority that shows that the food packaging product is safe to come into contact with food.
        /// </remarks>
        FoodPackagingContactCertificate,

        /// <summary>
        /// Packaging material composition report (Code: 644)
        /// </summary>
        /// <remarks>
        /// A document that shows the main structure that composes the packaging material.
        /// </remarks>
        PackagingMaterialCompositionReport,

        /// <summary>
        /// Export price certificate (Code: 645)
        /// </summary>
        /// <remarks>
        /// A certification executed by the competent authority from country of exportation stating the export price of the goods.
        /// </remarks>
        ExportPriceCertificate,

        /// <summary>
        /// Public price certificate (Code: 646)
        /// </summary>
        /// <remarks>
        /// A certification executed by the competent authority from country of production stating the price of the goods to the general public.
        /// </remarks>
        PublicPriceCertificate,

        /// <summary>
        /// Drug shelf life study report (Code: 647)
        /// </summary>
        /// <remarks>
        /// A document containing results from the study which determines the shelf life, namely the time period of storage at a specified condition within which a drug substance or drug product still meets its established specifications; its identity, strength, quality and purity.
        /// </remarks>
        DrugShelfLifeStudyReport,

        /// <summary>
        /// Certificate of compliance with standards of the World (Code: 648)
        /// </summary>
        /// <remarks>
        /// Organization for Animal Health (OIE) A certification that the products have been treated in a way consistent with the standards set by the World Organization for Animal Health (OIE).
        /// </remarks>
        CertificateOfComplianceWithStandardsOfTheWorld,

        /// <summary>
        /// Production facility license (Code: 649)
        /// </summary>
        /// <remarks>
        /// A license granted by a competent authority to a production facility for manufacturing specific products.
        /// </remarks>
        ProductionFacilityLicense,

        /// <summary>
        /// Handling order (Code: 650)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a cargo handling organization (port administration, terminal operator, etc.) for the removal or other handling of goods under their care.
        /// </remarks>
        HandlingOrder,

        /// <summary>
        /// Manufacturing license (Code: 651)
        /// </summary>
        /// <remarks>
        /// A license granted by a competent authority to a manufacturer for production of specific products.
        /// </remarks>
        ManufacturingLicense,

        /// <summary>
        /// Low risk country formal letter (Code: 652)
        /// </summary>
        /// <remarks>
        /// An official letter issued by an import authority granted to the importer of goods from a low risk country which allows the importer to place its products in the local market with certain favorable considerations.
        /// </remarks>
        LowRiskCountryFormalLetter,

        /// <summary>
        /// Previous correspondence (Code: 653)
        /// </summary>
        /// <remarks>
        /// Correspondence previously exchanged.
        /// </remarks>
        PreviousCorrespondence,

        /// <summary>
        /// Declaration for radioactive material (Code: 654)
        /// </summary>
        /// <remarks>
        /// A declaration to be presented to the competent authority when radioactive material moves cross-border.
        /// </remarks>
        DeclarationForRadioactiveMaterial,

        /// <summary>
        /// Gate pass (Code: 655)
        /// </summary>
        /// <remarks>
        /// Document/message authorizing goods specified therein to be brought out of a fenced-in port or terminal area.
        /// </remarks>
        GatePass,

        /// <summary>
        /// Resale information (Code: 656)
        /// </summary>
        /// <remarks>
        /// Document/message providing information on a resale.
        /// </remarks>
        ResaleInformation,

        /// <summary>
        /// Phytosanitary Re-export Certificate (Code: 657)
        /// </summary>
        /// <remarks>
        /// A message/document consistent with the model for re- export phytosanitary certificates of the IPPC, attesting that a consignment meets phytosanitary import requirements.
        /// </remarks>
        PhytosanitaryReExportCertificate,

        /// <summary>
        /// Bayplan/stowage plan, full (Code: 658)
        /// </summary>
        /// <remarks>
        /// A full bayplan containing all occupied and/or blocked stowage locations.
        /// </remarks>
        BayplanstowagePlanfull,

        /// <summary>
        /// Bayplan/stowage plan, partial (Code: 659)
        /// </summary>
        /// <remarks>
        /// A partial bayplan. containing only a selected part of the available stowage locations.
        /// </remarks>
        BayplanstowagePlanpartial,

        /// <summary>
        /// Waybill (Code: 700)
        /// </summary>
        /// <remarks>
        /// Non-negotiable document evidencing the contract for the transport of cargo.
        /// </remarks>
        Waybill,

        /// <summary>
        /// Universal (multipurpose) transport document (Code: 701)
        /// </summary>
        /// <remarks>
        /// Document/message evidencing a contract of carriage covering the movement of goods by any mode of transport, or combination of modes, for national as well as international transport, under any applicable international convention or national law and under the conditions of carriage of any carrier or transport operator undertaking or arranging the transport referred to in the document.
        /// </remarks>
        UniversalMultipurposeTransportDocument,

        /// <summary>
        /// Goods receipt, carriage (Code: 702)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a carrier or a carrier's agent, acknowledging receipt for carriage of goods specified therein on conditions stated or referred to in the document, enabling the carrier to issue a transport document.
        /// </remarks>
        GoodsReceiptcarriage,

        /// <summary>
        /// House waybill (Code: 703)
        /// </summary>
        /// <remarks>
        /// The document made out by an agent/consolidator which evidences the contract between the shipper and the agent/consolidator for the arrangement of carriage of goods.
        /// </remarks>
        HouseWaybill,

        /// <summary>
        /// Master bill of lading (Code: 704)
        /// </summary>
        /// <remarks>
        /// A bill of lading issued by the master of a vessel (in actuality the owner or charterer of the vessel). It could cover a number of house bills.
        /// </remarks>
        MasterBillOfLading,

        /// <summary>
        /// Bill of lading (Code: 705)
        /// </summary>
        /// <remarks>
        /// Negotiable document/message which evidences a contract of carriage by sea and the taking over or loading of goods by carrier, and by which carrier undertakes to deliver goods against surrender of the document. A provision in the document that goods are to be delivered to the order of a named person, or to order, or to bearer, constitutes such an undertaking.
        /// </remarks>
        BillOfLading,

        /// <summary>
        /// Bill of lading original (Code: 706)
        /// </summary>
        /// <remarks>
        /// The original of the bill of lading issued by a transport company. When issued by the maritime industry it could signify ownership of the cargo.
        /// </remarks>
        BillOfLadingOriginal,

        /// <summary>
        /// Bill of lading copy (Code: 707)
        /// </summary>
        /// <remarks>
        /// A copy of the bill of lading issued by a transport company.
        /// </remarks>
        BillOfLadingCopy,

        /// <summary>
        /// Empty container bill (Code: 708)
        /// </summary>
        /// <remarks>
        /// Bill of lading indicating an empty container.
        /// </remarks>
        EmptyContainerBill,

        /// <summary>
        /// Tanker bill of lading (Code: 709)
        /// </summary>
        /// <remarks>
        /// Document which evidences a transport of liquid bulk cargo.
        /// </remarks>
        TankerBillOfLading,

        /// <summary>
        /// Sea waybill (Code: 710)
        /// </summary>
        /// <remarks>
        /// Non-negotiable document which evidences a contract for the carriage of goods by sea and the taking over of the goods by the carrier, and by which the carrier undertakes to deliver the goods to the consignee named in the document.
        /// </remarks>
        SeaWaybill,

        /// <summary>
        /// Inland waterway bill of lading (Code: 711)
        /// </summary>
        /// <remarks>
        /// Negotiable transport document made out to a named person, to order or to bearer, signed by the carrier and handed to the sender after receipt of the goods.
        /// </remarks>
        InlandWaterwayBillOfLading,

        /// <summary>
        /// Non-negotiable maritime transport document (generic) (Code: 712)
        /// </summary>
        /// <remarks>
        /// Non-negotiable document which evidences a contract for the carriage of goods by sea and the taking over or loading of the goods by the carrier, and by which the carrier undertakes to deliver the goods to the consignee named in the document. E.g. Sea waybill. Remark: Synonymous with "straight" or "non-negotiable Bill of lading" used in certain countries, e.g. Canada.
        /// </remarks>
        NonNegotiableMaritimeTransportDocumentGeneric,

        /// <summary>
        /// Mate's receipt (Code: 713)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a ship's officer to acknowledge that a specified consignment has been received on board a vessel, and the apparent condition of the goods; enabling the carrier to issue a Bill of lading.
        /// </remarks>
        MatesReceipt,

        /// <summary>
        /// House bill of lading (Code: 714)
        /// </summary>
        /// <remarks>
        /// The bill of lading issued not by the carrier but by the freight forwarder/consolidator known by the carrier.
        /// </remarks>
        HouseBillOfLading,

        /// <summary>
        /// Letter of indemnity for non-surrender of bill of lading (Code: 715)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a commercial party or a bank of an insurance company accepting responsibility to the beneficiary of the indemnity in accordance with the terms thereof.
        /// </remarks>
        LetterOfIndemnityForNonSurrenderOfBillOfLading,

        /// <summary>
        /// Forwarder's bill of lading (Code: 716)
        /// </summary>
        /// <remarks>
        /// Non-negotiable document issued by a freight forwarder evidencing a contract for the carriage of goods by sea and the taking over or loading of the goods by the freight forwarder, and by which the freight forwarder undertakes to deliver the goods to the consignee named in the document.
        /// </remarks>
        ForwardersBillOfLading,

        /// <summary>
        /// Residence permit (Code: 717)
        /// </summary>
        /// <remarks>
        /// A document authorizing residence.
        /// </remarks>
        ResidencePermit,

        /// <summary>
        /// Seaman�s book (Code: 718)
        /// </summary>
        /// <remarks>
        /// A national identity document issued to professional seamen that contains a record of their rank and service career.
        /// </remarks>
        SeamansBook,

        /// <summary>
        /// General message (Code: 719)
        /// </summary>
        /// <remarks>
        /// Document/message providing agreed textual information.
        /// </remarks>
        GeneralMessage,

        /// <summary>
        /// Rail consignment note (generic term) (Code: 720)
        /// </summary>
        /// <remarks>
        /// Transport document constituting a contract for the carriage of goods between the sender and the carrier (the railway). For international rail traffic, this document must conform to the model prescribed by the international conventions concerning carriage of goods by rail, e.g. CIM Convention, SMGS Convention.
        /// </remarks>
        RailConsignmentNoteGenericTerm,

        /// <summary>
        /// Product data response (Code: 721)
        /// </summary>
        /// <remarks>
        /// Document/message responding to a previously received Product Data document/message.
        /// </remarks>
        ProductDataResponse,

        /// <summary>
        /// Road list-SMGS (Code: 722)
        /// </summary>
        /// <remarks>
        /// Accounting document, one copy of which is drawn up for each consignment note; it accompanies the consignment over the whole route and is a rail transport document.
        /// </remarks>
        RoadListSMGS,

        /// <summary>
        /// Escort official recognition (Code: 723)
        /// </summary>
        /// <remarks>
        /// Document/message which gives right to the owner to exert all functions normally transferred to a guard in a train by which an escorted consignment is transported.
        /// </remarks>
        EscortOfficialRecognition,

        /// <summary>
        /// Recharging document (Code: 724)
        /// </summary>
        /// <remarks>
        /// Fictitious transport document regarding a previous transport, enabling a carrier's agent to give to another carrier's agent (in a different country) the possibility to collect charges relating to the original transport (rail environment).
        /// </remarks>
        RechargingDocument,

        /// <summary>
        /// Manufacturer raised order (Code: 725)
        /// </summary>
        /// <remarks>
        /// Document/message providing details of an order which has been raised by a manufacturer.
        /// </remarks>
        ManufacturerRaisedOrder,

        /// <summary>
        /// Manufacturer raised consignment order (Code: 726)
        /// </summary>
        /// <remarks>
        /// Document/message providing details of a consignment order which has been raised by a manufacturer.
        /// </remarks>
        ManufacturerRaisedConsignmentOrder,

        /// <summary>
        /// Price/sales catalogue not containing commercial information (Code: 727)
        /// </summary>
        /// <remarks>
        /// A price/sales catalogue message containing no commercial information, such as prices, terms or conditions.
        /// </remarks>
        PricesalesCatalogueNotContainingCommercialInformation,

        /// <summary>
        /// Price/sales catalogue containing commercial information (Code: 728)
        /// </summary>
        /// <remarks>
        /// A price/sales catalogue message containing only commercial terms or conditions data.
        /// </remarks>
        PricesalesCatalogueContainingCommercialInformation,

        /// <summary>
        /// Returns advice (Code: 729)
        /// </summary>
        /// <remarks>
        /// Document/message by means of which the buyer informs the seller about the despatch of returned goods.
        /// </remarks>
        ReturnsAdvice,

        /// <summary>
        /// Road consignment note (Code: 730)
        /// </summary>
        /// <remarks>
        /// Transport document/message which evidences a contract between a carrier and a sender for the carriage of goods by road (generic term). Remark: For international road traffic, this document must contain at least the particulars prescribed by the convention on the contract for the international carriage of goods by road (CMR).
        /// </remarks>
        RoadConsignmentNote,

        /// <summary>
        /// Commercial account summary (Code: 731)
        /// </summary>
        /// <remarks>
        /// A message enabling the transmission of commercial data concerning payments made and outstanding items on an account over a period of time.
        /// </remarks>
        CommercialAccountSummary,

        /// <summary>
        /// Announcement for returns (Code: 732)
        /// </summary>
        /// <remarks>
        /// A message by which a party announces to another party details of goods for return due to specified reasons (e.g. returns for repair, returns because of damage, etc).
        /// </remarks>
        AnnouncementForReturns,

        /// <summary>
        /// Instruction for returns (Code: 733)
        /// </summary>
        /// <remarks>
        /// A message by which a party informs another party whether and how goods shall be returned.
        /// </remarks>
        InstructionForReturns,

        /// <summary>
        /// Sales forecast report (Code: 734)
        /// </summary>
        /// <remarks>
        /// A message enabling companies to exchange or report electronically, basic sales forecast data related to products or services, including the corresponding location, time period, product identification, pricing and quantity information. It enables the recip.
        /// </remarks>
        SalesForecastReport,

        /// <summary>
        /// Sales data report (Code: 735)
        /// </summary>
        /// <remarks>
        /// A message enabling companies to exchange or report electronically, basic sales data related to products or services, including the corresponding location, time period, product identification, pricing and quantity information. It enables the recipient to p.
        /// </remarks>
        SalesDataReport,

        /// <summary>
        /// Standing inquiry on complete product information (Code: 736)
        /// </summary>
        /// <remarks>
        /// A product inquiry which stands until it is cancelled. It requests not only the updates since last time, but always the complete product information of a data supplier. This means that within the standing request every time a complete download of the respe.
        /// </remarks>
        StandingInquiryOnCompleteProductInformation,

        /// <summary>
        /// Proof of delivery (Code: 737)
        /// </summary>
        /// <remarks>
        /// A message by which a consignee provides for a carrier proof of delivery of a consignment.
        /// </remarks>
        ProofOfDelivery,

        /// <summary>
        /// Cargo/goods handling and movement message (Code: 738)
        /// </summary>
        /// <remarks>
        /// A message from a party to a warehouse, distribution centre, or logistics service provider identifying the handling services and where required the movement of specified goods, limited to warehouses within the jurisdiction of the distribution centre or log.
        /// </remarks>
        CargogoodsHandlingAndMovementMessage,

        /// <summary>
        /// Metered services consumption report supporting an invoice (Code: 739)
        /// </summary>
        /// <remarks>
        /// Document/message providing metered consumption details supporiting an invoice.
        /// </remarks>
        MeteredServicesConsumptionReportSupportingAnInvoice,

        /// <summary>
        /// Air waybill (Code: 740)
        /// </summary>
        /// <remarks>
        /// Document/message made out by or on behalf of the shipper which evidences the contract between the shipper and carrier(s) for carriage of goods over routes of the carrier(s) and which is identified by the airline prefix issuing the document plus a serial (IATA).
        /// </remarks>
        AirWaybill,

        /// <summary>
        /// Master air waybill (Code: 741)
        /// </summary>
        /// <remarks>
        /// Document/message made out by or on behalf of the agent/consolidator which evidences the contract between the agent/consolidator and carrier(s) for carriage of goods over routes of the carrier(s) for a consignment consisting of goods originated by more than one shipper (IATA).
        /// </remarks>
        MasterAirWaybill,

        /// <summary>
        /// Metered services consumption report (Code: 742)
        /// </summary>
        /// <remarks>
        /// Document/message providing metered consumption details.
        /// </remarks>
        MeteredServicesConsumptionReport,

        /// <summary>
        /// Substitute air waybill (Code: 743)
        /// </summary>
        /// <remarks>
        /// A temporary air waybill which contains only limited information because of the absence of the original.
        /// </remarks>
        SubstituteAirWaybill,

        /// <summary>
        /// Crew's effects declaration (Code: 744)
        /// </summary>
        /// <remarks>
        /// Declaration to Customs regarding the personal effects of crew members aboard the conveyance; equivalent to IMO FAL 4.
        /// </remarks>
        CrewsEffectsDeclaration,

        /// <summary>
        /// Passenger list (Code: 745)
        /// </summary>
        /// <remarks>
        /// Declaration to Customs regarding passengers aboard the conveyance; equivalent to IMO FAL 6.
        /// </remarks>
        PassengerList,

        /// <summary>
        /// Delivery notice (rail transport) (Code: 746)
        /// </summary>
        /// <remarks>
        /// Document/message created by the consignor or by the departure station, joined to the transport or sent to the consignee, giving the possibility to the consignee or the arrival station to attest the delivery of the goods. The document must be returned to the consignor or to the departure station.
        /// </remarks>
        DeliveryNoticeRailTransport,

        /// <summary>
        /// Payroll deductions advice (Code: 747)
        /// </summary>
        /// <remarks>
        /// A message sent by a party (usually an employer or its representative) to a service providing organisation, to detail payroll deductions paid on behalf of its employees to the service providing organisation.
        /// </remarks>
        PayrollDeductionsAdvice,

        /// <summary>
        /// Consignment despatch advice (Code: 748)
        /// </summary>
        /// <remarks>
        /// Document/message by means of which the supplier informs the buyer about the despatch of goods ordered on consignment (goods to be delivered into stock with agreement on payment when goods are sold out of this stock).
        /// </remarks>
        ConsignmentDespatchAdvice,

        /// <summary>
        /// Transport equipment gross mass verification message (Code: 749)
        /// </summary>
        /// <remarks>
        /// Message containing information regarding gross mass verification of transport equipment.
        /// </remarks>
        TransportEquipmentGrossMassVerificationMessage,

        /// <summary>
        /// Despatch note (post parcels) (Code: 750)
        /// </summary>
        /// <remarks>
        /// Document/message which, according to Article 106 of the "Agreement concerning Postal Parcels" under the UPU convention, is to accompany post parcels.
        /// </remarks>
        DespatchNotePostParcels,

        /// <summary>
        /// Invoice information for accounting purposes (Code: 751)
        /// </summary>
        /// <remarks>
        /// A document / message containing accounting related information such as monetary summations, seller id and VAT information. This may not be a complete invoice according to legal requirements. For instance the line item information might be excluded.
        /// </remarks>
        InvoiceInformationForAccountingPurposes,

        /// <summary>
        /// Multimodal/combined transport document (generic) (Code: 760)
        /// </summary>
        /// <remarks>
        /// A transport document used when more than one mode of transportation is involved in the movement of cargo. It is a contract of carriage and receipt of the cargo for a multimodal transport. It indicates the place where the responsible transport company in the move takes responsibility for the cargo, the place where the responsibility of this transport company in the move ends and the conveyances involved.
        /// </remarks>
        MultimodalcombinedTransportDocumentGeneric,

        /// <summary>
        /// Through bill of lading (Code: 761)
        /// </summary>
        /// <remarks>
        /// Bill of lading which evidences a contract of carriage from one place to another in separate stages of which at least one stage is a sea transit, and by which the issuing carrier accepts responsibility for the carriage as set forth in the through bill of lading.
        /// </remarks>
        ThroughBillOfLading,

        /// <summary>
        /// Forwarder's certificate of transport (Code: 763)
        /// </summary>
        /// <remarks>
        /// Negotiable document/message issued by a forwarder to certify that he has taken charge of a specified consignment for despatch and delivery in accordance with the consignor's instructions, as indicated in the document, and that he accepts responsibility for delivery of the goods to the holder of the document through the intermediary of a delivery agent of his choice. E.g. FIATA-FCT.
        /// </remarks>
        ForwardersCertificateOfTransport,

        /// <summary>
        /// Combined transport document (generic) (Code: 764)
        /// </summary>
        /// <remarks>
        /// Negotiable or non-negotiable document evidencing a contract for the performance and/or procurement of performance of combined transport of goods and bearing on its face either the heading "Negotiable combined transport document issued subject to Uniform Rules for a Combined Transport Document (ICC Brochure No. 298)" or the heading "Non-negotiable Combined Transport Document issued subject to Uniform Rules for a Combined Transport Document (ICC Brochure No. 298)".
        /// </remarks>
        CombinedTransportDocumentGeneric,

        /// <summary>
        /// Multimodal transport document (generic) (Code: 765)
        /// </summary>
        /// <remarks>
        /// Document/message which evidences a multimodal transport contract, the taking in charge of the goods by the multimodal transport operator, and an undertaking by him to deliver the goods in accordance with the terms of the contract. (International Convention on Multimodal Transport of Goods).
        /// </remarks>
        MultimodalTransportDocumentGeneric,

        /// <summary>
        /// Combined transport bill of lading/multimodal bill of lading (Code: 766)
        /// </summary>
        /// <remarks>
        /// Document which evidences a multimodal transport contract, the taking in charge of the goods by the multimodal transport operator, and an undertaking by him to deliver the goods in accordance with the terms of the contract.
        /// </remarks>
        CombinedTransportBillOfLadingmultimodalBillOfLading,

        /// <summary>
        /// Booking confirmation (Code: 770)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a carrier to confirm that space has been reserved for a consignment in means of transport.
        /// </remarks>
        BookingConfirmation,

        /// <summary>
        /// Calling forward notice (Code: 775)
        /// </summary>
        /// <remarks>
        /// Instructions for release or delivery of goods.
        /// </remarks>
        CallingForwardNotice,

        /// <summary>
        /// Freight invoice (Code: 780)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a transport operation specifying freight costs and charges incurred for a transport operation and stating conditions of payment.
        /// </remarks>
        FreightInvoice,

        /// <summary>
        /// Arrival notice (goods) (Code: 781)
        /// </summary>
        /// <remarks>
        /// Notification from the carrier to the consignee in writing, by telephone or by any other means (express letter, message, telegram, etc.) informing him that a consignment addressed to him is being or will shortly be held at his disposal at a specified point in the place of destination.
        /// </remarks>
        ArrivalNoticeGoods,

        /// <summary>
        /// Notice of circumstances preventing delivery (goods) (Code: 782)
        /// </summary>
        /// <remarks>
        /// Request made by the carrier to the sender, or, as the case may be, the consignee, for instructions as to the disposal of the consignment when circumstances prevent delivery and the return of the goods has not been requested by the consignor in the transport document.
        /// </remarks>
        NoticeOfCircumstancesPreventingDeliveryGoods,

        /// <summary>
        /// Notice of circumstances preventing transport (goods) (Code: 783)
        /// </summary>
        /// <remarks>
        /// Request made by the carrier to the sender, or, the consignee as the case may be, for instructions as to the disposal of the goods when circumstances prevent transport before departure or en route, after acceptance of the consignment concerned.
        /// </remarks>
        NoticeOfCircumstancesPreventingTransportGoods,

        /// <summary>
        /// Delivery notice (goods) (Code: 784)
        /// </summary>
        /// <remarks>
        /// Notification in writing, sent by the carrier to the sender, to inform him at his request of the actual date of delivery of the goods.
        /// </remarks>
        DeliveryNoticeGoods,

        /// <summary>
        /// Cargo manifest (Code: 785)
        /// </summary>
        /// <remarks>
        /// Listing of goods comprising the cargo carried in a means of transport or in a transport-unit. The cargo manifest gives the commercial particulars of the goods, such as transport document numbers, consignors, consignees, shipping marks, number and kind of packages and descriptions and quantities of the goods.
        /// </remarks>
        CargoManifest,

        /// <summary>
        /// Freight manifest (Code: 786)
        /// </summary>
        /// <remarks>
        /// Document/message containing the same information as a cargo manifest, and additional details on freight amounts, charges, etc.
        /// </remarks>
        FreightManifest,

        /// <summary>
        /// Bordereau (Code: 787)
        /// </summary>
        /// <remarks>
        /// Document/message used in road transport, listing the cargo carried on a road vehicle, often referring to appended copies of Road consignment note.
        /// </remarks>
        Bordereau,

        /// <summary>
        /// Container manifest (unit packing list) (Code: 788)
        /// </summary>
        /// <remarks>
        /// Document/message specifying the contents of particular freight containers or other transport units, prepared by the party responsible for their loading into the container or unit.
        /// </remarks>
        ContainerManifestUnitPackingList,

        /// <summary>
        /// Charges note (Code: 789)
        /// </summary>
        /// <remarks>
        /// Document used by the rail organization to indicate freight charges or additional charges in each case where the departure station is not able to calculate the charges for the total voyage (e.g. tariff not yet updated, part of voyage not covered by the tariff). This document must be considered as joined to the transport.
        /// </remarks>
        ChargesNote,

        /// <summary>
        /// Advice of collection (Code: 790)
        /// </summary>
        /// <remarks>
        /// (1030) Document that is joined to the transport or sent by separate means, giving to the departure rail organization the proof that the cash-on delivery amount has been encashed by the arrival rail organization before reimbursement of the consignor.
        /// </remarks>
        AdviceOfCollection,

        /// <summary>
        /// Safety of ship certificate (Code: 791)
        /// </summary>
        /// <remarks>
        /// Document certifying a ship's safety to a specified date.
        /// </remarks>
        SafetyOfShipCertificate,

        /// <summary>
        /// Safety of radio certificate (Code: 792)
        /// </summary>
        /// <remarks>
        /// Document certifying the safety of a ship's radio facilities to a specified date.
        /// </remarks>
        SafetyOfRadioCertificate,

        /// <summary>
        /// Safety of equipment certificate (Code: 793)
        /// </summary>
        /// <remarks>
        /// Document certifying the safety of a ship's equipment to a specified date.
        /// </remarks>
        SafetyOfEquipmentCertificate,

        /// <summary>
        /// Civil liability for oil certificate (Code: 794)
        /// </summary>
        /// <remarks>
        /// Document declaring a ship owner's liability for oil propelling or carried on a vessel.
        /// </remarks>
        CivilLiabilityForOilCertificate,

        /// <summary>
        /// Loadline document (Code: 795)
        /// </summary>
        /// <remarks>
        /// Document specifying the limit of a ship's legal submersion under various conditions.
        /// </remarks>
        LoadlineDocument,

        /// <summary>
        /// Derat document (Code: 796)
        /// </summary>
        /// <remarks>
        /// Document certifying that a ship is free of rats, valid to a specified date.
        /// </remarks>
        DeratDocument,

        /// <summary>
        /// Maritime declaration of health (Code: 797)
        /// </summary>
        /// <remarks>
        /// Document certifying the health condition on board a vessel, valid to a specified date.
        /// </remarks>
        MaritimeDeclarationOfHealth,

        /// <summary>
        /// Certificate of registry (Code: 798)
        /// </summary>
        /// <remarks>
        /// Official certificate stating the vessel's registry.
        /// </remarks>
        CertificateOfRegistry,

        /// <summary>
        /// Ship's stores declaration (Code: 799)
        /// </summary>
        /// <remarks>
        /// Declaration to Customs regarding the contents of the ship's stores (equivalent to IMO FAL 3) i.e. goods intended for consumption by passengers/crew on board vessels, aircraft or trains, whether or not sold or landed; goods necessary for operation/maintenance of conveyance, including fuel/lubricants, excluding spare parts/equipment (IMO).
        /// </remarks>
        ShipsStoresDeclaration,

        /// <summary>
        /// Export licence, application for (Code: 810)
        /// </summary>
        /// <remarks>
        /// Application for a permit issued by a government authority permitting exportation of a specified commodity subject to specified conditions as quantity, country of destination, etc.
        /// </remarks>
        ExportLicenceapplicationFor,

        /// <summary>
        /// Export licence (Code: 811)
        /// </summary>
        /// <remarks>
        /// Permit issued by a government authority permitting exportation of a specified commodity subject to specified conditions as quantity, country of destination, etc. Synonym: Embargo permit.
        /// </remarks>
        ExportLicence,

        /// <summary>
        /// Exchange control declaration, export (Code: 812)
        /// </summary>
        /// <remarks>
        /// Document/message completed by an exporter/seller as a means whereby the competent body may control that the amount of foreign exchange accrued from a trade transaction is repatriated in accordance with the conditions of payment and exchange control regulations in force.
        /// </remarks>
        ExchangeControlDeclarationexport,

        /// <summary>
        /// Despatch note model T (Code: 820)
        /// </summary>
        /// <remarks>
        /// European community transit declaration.
        /// </remarks>
        DespatchNoteModelT,

        /// <summary>
        /// Despatch note model T1 (Code: 821)
        /// </summary>
        /// <remarks>
        /// Transit declaration for goods circulating under internal community transit procedures (between European Union (EU) countries).
        /// </remarks>
        DespatchNoteModelT1,

        /// <summary>
        /// Despatch note model T2 (Code: 822)
        /// </summary>
        /// <remarks>
        /// Ascertainment that the declared goods were originally produced in an European Union (EU) country.
        /// </remarks>
        DespatchNoteModelT2,

        /// <summary>
        /// Control document T5 (Code: 823)
        /// </summary>
        /// <remarks>
        /// Control document (export declaration) used particularly in case of re-sending without use with only VAT collection, refusal, unconformity with contract etc.
        /// </remarks>
        ControlDocumentT5,

        /// <summary>
        /// Re-sending consignment note (Code: 824)
        /// </summary>
        /// <remarks>
        /// Rail consignment note prepared by the consignor for the facilitation of an eventual return to the origin of the goods.
        /// </remarks>
        ReSendingConsignmentNote,

        /// <summary>
        /// Despatch note model T2L (Code: 825)
        /// </summary>
        /// <remarks>
        /// Ascertainment that the declared goods were originally produced in an European Union (EU) country. May only be used for goods that are loaded on one single means of transport in one single departure point for one single delivery point.
        /// </remarks>
        DespatchNoteModelT2L,

        /// <summary>
        /// Goods declaration for exportation (Code: 830)
        /// </summary>
        /// <remarks>
        /// Document/message by which goods are declared for export Customs clearance, conforming to the layout key set out at Appendix I to Annex C.1 concerning outright exportation to the Kyoto convention (CCC). Within a Customs union, "for despatch" may have the same meaning as "for exportation".
        /// </remarks>
        GoodsDeclarationForExportation,

        /// <summary>
        /// Cargo declaration (departure) (Code: 833)
        /// </summary>
        /// <remarks>
        /// Generic term, sometimes referred to as Freight declaration, applied to the documents providing the particulars required by the Customs concerning the cargo (freight) carried by commercial means of transport (CCC).
        /// </remarks>
        CargoDeclarationDeparture,

        /// <summary>
        /// Application for goods control certificate (Code: 840)
        /// </summary>
        /// <remarks>
        /// Document/message submitted to a competent body by party requesting a Goods control certificate to be issued in accordance with national or international standards, or conforming to legislation in the importing country, or as specified in the contract.
        /// </remarks>
        ApplicationForGoodsControlCertificate,

        /// <summary>
        /// Goods control certificate (Code: 841)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a competent body evidencing the quality of the goods described therein, in accordance with national or international standards, or conforming to legislation in the importing country, or as specified in the contract.
        /// </remarks>
        GoodsControlCertificate,

        /// <summary>
        /// Application for phytosanitary certificate (Code: 850)
        /// </summary>
        /// <remarks>
        /// Document/message submitted to a competent body by party requesting a Phytosanitary certificate to be issued.
        /// </remarks>
        ApplicationForPhytosanitaryCertificate,

        /// <summary>
        /// Phytosanitary certificate (Code: 851)
        /// </summary>
        /// <remarks>
        /// A message/doucment consistent with the model for certificates of the IPPC, attesting that a consignment meets phytosanitary import requirements.
        /// </remarks>
        PhytosanitaryCertificate,

        /// <summary>
        /// Sanitary certificate (Code: 852)
        /// </summary>
        /// <remarks>
        /// Document/message issued by the competent authority in the exporting country evidencing that alimentary and animal products, including dead animals, are fit for human consumption, and giving details, when relevant, of controls undertaken.
        /// </remarks>
        SanitaryCertificate,

        /// <summary>
        /// Veterinary certificate (Code: 853)
        /// </summary>
        /// <remarks>
        /// Document/message issued by the competent authority in the exporting country evidencing that live animals or birds are not infested or infected with disease, and giving details regarding their provenance, and of vaccinations and other treatment to which they have been subjected.
        /// </remarks>
        VeterinaryCertificate,

        /// <summary>
        /// Application for inspection certificate (Code: 855)
        /// </summary>
        /// <remarks>
        /// Document/message submitted to a competent body by a party requesting an Inspection certificate to be issued in accordance with national or international standards, or conforming to legislation in the country in which it is required, or as specified in the contract.
        /// </remarks>
        ApplicationForInspectionCertificate,

        /// <summary>
        /// Inspection certificate (Code: 856)
        /// </summary>
        /// <remarks>
        /// Document/message issued by a competent body evidencing that the goods described therein have been inspected in accordance with national or international standards, in conformity with legislation in the country in which the inspection is required, or as specified in the contract.
        /// </remarks>
        InspectionCertificate,

        /// <summary>
        /// Certificate of origin, application for (Code: 860)
        /// </summary>
        /// <remarks>
        /// Document/message submitted to a competent body by an interested party requesting a Certificate of origin to be issued in accordance with relevant criteria, and on the basis of evidence of the origin of the goods.
        /// </remarks>
        CertificateOfOriginapplicationFor,

        /// <summary>
        /// Certificate of origin (Code: 861)
        /// </summary>
        /// <remarks>
        /// Document/message identifying goods, in which the authority or body authorized to issue it certifies expressly that the goods to which the certificate relates originate in a specific country. The word "country" may include a group of countries, a region or a part of a country. This certificate may also include a declaration by the manufacturer, producer, supplier, exporter or other competent person.
        /// </remarks>
        CertificateOfOrigin,

        /// <summary>
        /// Declaration of origin (Code: 862)
        /// </summary>
        /// <remarks>
        /// Appropriate statement as to the origin of the goods, made in connection with their exportation by the manufacturer, producer, supplier, exporter or other competent person on the Commercial invoice or any other document relating to the goods (CCC).
        /// </remarks>
        DeclarationOfOrigin,

        /// <summary>
        /// Regional appellation certificate (Code: 863)
        /// </summary>
        /// <remarks>
        /// Certificate drawn up in accordance with the rules laid down by an authority or approved body, certifying that the goods described therein qualify for a designation specific to the given region (e.g. champagne, port wine, Parmesan cheese).
        /// </remarks>
        RegionalAppellationCertificate,

        /// <summary>
        /// Preference certificate of origin (Code: 864)
        /// </summary>
        /// <remarks>
        /// Document/message describing a certificate of origin meeting the requirements for preferential treatment.
        /// </remarks>
        PreferenceCertificateOfOrigin,

        /// <summary>
        /// Certificate of origin form GSP (Code: 865)
        /// </summary>
        /// <remarks>
        /// Specific form of certificate of origin for goods qualifying for preferential treatment under the generalized system of preferences (includes a combined declaration of origin and certificate, form A).
        /// </remarks>
        CertificateOfOriginFormGSP,

        /// <summary>
        /// Consular invoice (Code: 870)
        /// </summary>
        /// <remarks>
        /// Document/message to be prepared by an exporter in his country and presented to a diplomatic representation of the importing country for endorsement and subsequently to be presented by the importer in connection with the import of the goods described therein.
        /// </remarks>
        ConsularInvoice,

        /// <summary>
        /// Dangerous goods declaration (Code: 890)
        /// </summary>
        /// <remarks>
        /// (1115) Document/message issued by a consignor in accordance with applicable conventions or regulations, describing hazardous goods or materials for transport purposes, and stating that the latter have been packed and labelled in accordance with the provisions of the relevant conventions or regulations.
        /// </remarks>
        DangerousGoodsDeclaration,

        /// <summary>
        /// Statistical document, export (Code: 895)
        /// </summary>
        /// <remarks>
        /// Document/message in which an exporter provides information about exported goods required by the body responsible for the collection of international trade statistics.
        /// </remarks>
        StatisticalDocumentexport,

        /// <summary>
        /// INTRASTAT declaration (Code: 896)
        /// </summary>
        /// <remarks>
        /// Document/message in which a declarant provides information about goods required by the body responsible for the collection of trade statistics.
        /// </remarks>
        INTRASTATDeclaration,

        /// <summary>
        /// Delivery verification certificate (Code: 901)
        /// </summary>
        /// <remarks>
        /// Document/message whereby an official authority (Customs or governmental) certifies that goods have been delivered.
        /// </remarks>
        DeliveryVerificationCertificate,

        /// <summary>
        /// Import licence, application for (Code: 910)
        /// </summary>
        /// <remarks>
        /// Document/message in which an interested party applies to the competent body for authorization to import either a limited quantity of articles subject to import restrictions, or an unlimited quantity of such articles during a limited period, and specifies the kind of articles, their origin and value, etc.
        /// </remarks>
        ImportLicenceapplicationFor,

        /// <summary>
        /// Import licence (Code: 911)
        /// </summary>
        /// <remarks>
        /// Document/message issued by the competent body in accordance with import regulations in force, by which authorization is granted to a named party to import either a limited quantity of designated articles or an unlimited quantity of such articles during a limited period, under conditions specified in the document.
        /// </remarks>
        ImportLicence,

        /// <summary>
        /// Customs declaration without commercial detail (Code: 913)
        /// </summary>
        /// <remarks>
        /// CUSDEC transmission that does not include data from the commercial detail section of the message.
        /// </remarks>
        CustomsDeclarationWithoutCommercialDetail,

        /// <summary>
        /// Customs declaration with commercial and item detail (Code: 914)
        /// </summary>
        /// <remarks>
        /// CUSDEC transmission that includes data from both the commercial detail and item detail sections of the message.
        /// </remarks>
        CustomsDeclarationWithCommercialAndItemDetail,

        /// <summary>
        /// Customs declaration without item detail (Code: 915)
        /// </summary>
        /// <remarks>
        /// CUSDEC transmission that does not include data from the item detail section of the message.
        /// </remarks>
        CustomsDeclarationWithoutItemDetail,

        /// <summary>
        /// Related document (Code: 916)
        /// </summary>
        /// <remarks>
        /// Document that has a relationship with the stated document/message.
        /// </remarks>
        RelatedDocument,

        /// <summary>
        /// Receipt (Customs) (Code: 917)
        /// </summary>
        /// <remarks>
        /// Receipt for Customs duty/tax/fee paid.
        /// </remarks>
        ReceiptCustoms,

        /// <summary>
        /// Application for exchange allocation (Code: 925)
        /// </summary>
        /// <remarks>
        /// Document/message whereby an importer/buyer requests the competent body to allocate an amount of foreign exchange to be transferred to an exporter/seller in payment for goods.
        /// </remarks>
        ApplicationForExchangeAllocation,

        /// <summary>
        /// Foreign exchange permit (Code: 926)
        /// </summary>
        /// <remarks>
        /// Document/message issued by the competent body authorizing an importer/buyer to transfer an amount of foreign exchange to an exporter/seller in payment for goods.
        /// </remarks>
        ForeignExchangePermit,

        /// <summary>
        /// Exchange control declaration (import) (Code: 927)
        /// </summary>
        /// <remarks>
        /// Document/message completed by an importer/buyer as a means for the competent body to control that a trade transaction for which foreign exchange has been allocated has been executed and that money has been transferred in accordance with the conditions of payment and the exchange control regulations in force.
        /// </remarks>
        ExchangeControlDeclarationImport,

        /// <summary>
        /// Goods declaration for importation (Code: 929)
        /// </summary>
        /// <remarks>
        /// Document/message by which goods are declared for import Customs clearance [sister entry of 830].
        /// </remarks>
        GoodsDeclarationForImportation,

        /// <summary>
        /// Goods declaration for home use (Code: 930)
        /// </summary>
        /// <remarks>
        /// Document/message by which goods are declared for import Customs clearance according to Annex B.1 (concerning clearance for home use) to the Kyoto convention (CCC).
        /// </remarks>
        GoodsDeclarationForHomeUse,

        /// <summary>
        /// Customs immediate release declaration (Code: 931)
        /// </summary>
        /// <remarks>
        /// Document/message issued by an importer notifying Customs that goods have been removed from an importing means of transport to the importer's premises under a Customs- approved arrangement for immediate release, or requesting authorization to do so.
        /// </remarks>
        CustomsImmediateReleaseDeclaration,

        /// <summary>
        /// Customs delivery note (Code: 932)
        /// </summary>
        /// <remarks>
        /// Document/message whereby a Customs authority releases goods under its control to be placed at the disposal of the party concerned. Synonym: Customs release note.
        /// </remarks>
        CustomsDeliveryNote,

        /// <summary>
        /// Cargo declaration (arrival) (Code: 933)
        /// </summary>
        /// <remarks>
        /// Generic term, sometimes referred to as Freight declaration, applied to the documents providing the particulars required by the Customs concerning the cargo (freight) carried by commercial means of transport (CCC).
        /// </remarks>
        CargoDeclarationArrival,

        /// <summary>
        /// Value declaration (Code: 934)
        /// </summary>
        /// <remarks>
        /// Document/message in which a declarant (importer) states the invoice or other price (e.g. selling price, price of identical goods), and specifies costs for freight, insurance and packing, etc., terms of delivery and payment, any relationship with the trading partner, etc., for the purpose of determining the Customs value of goods imported.
        /// </remarks>
        ValueDeclaration,

        /// <summary>
        /// Customs invoice (Code: 935)
        /// </summary>
        /// <remarks>
        /// Document/message required by the Customs in an importing country in which an exporter states the invoice or other price (e.g. selling price, price of identical goods), and specifies costs for freight, insurance and packing, etc., terms of delivery and payment, for the purpose of determining the Customs value in the importing country of goods consigned to that country.
        /// </remarks>
        CustomsInvoice,

        /// <summary>
        /// Customs declaration (post parcels) (Code: 936)
        /// </summary>
        /// <remarks>
        /// Document/message which, according to Article 106 of the "Agreement concerning Postal Parcels" under the UPU Convention, must accompany post parcels and in which the contents of such parcels are specified.
        /// </remarks>
        CustomsDeclarationPostParcels,

        /// <summary>
        /// Tax declaration (value added tax) (Code: 937)
        /// </summary>
        /// <remarks>
        /// Document/message in which an importer states the pertinent information required by the competent body for assessment of value-added tax.
        /// </remarks>
        TaxDeclarationValueAddedTax,

        /// <summary>
        /// Tax declaration (general) (Code: 938)
        /// </summary>
        /// <remarks>
        /// Document/message containing a general tax declaration.
        /// </remarks>
        TaxDeclarationGeneral,

        /// <summary>
        /// Tax demand (Code: 940)
        /// </summary>
        /// <remarks>
        /// Document/message containing the demand of tax.
        /// </remarks>
        TaxDemand,

        /// <summary>
        /// Embargo permit (Code: 941)
        /// </summary>
        /// <remarks>
        /// Document/message giving the permission to export specified goods.
        /// </remarks>
        EmbargoPermit,

        /// <summary>
        /// Goods declaration for Customs transit (Code: 950)
        /// </summary>
        /// <remarks>
        /// Document/message by which the sender declares goods for Customs transit according to Annex E.1 (concerning Customs transit) to the Kyoto convention (CCC).
        /// </remarks>
        GoodsDeclarationForCustomsTransit,

        /// <summary>
        /// TIF form (Code: 951)
        /// </summary>
        /// <remarks>
        /// International Customs transit document by which the sender declares goods for carriage by rail in accordance with the provisions of the 1952 International Convention to facilitate the crossing of frontiers for goods carried by rail (TIF Convention of UIC).
        /// </remarks>
        TIFForm,

        /// <summary>
        /// TIR carnet (Code: 952)
        /// </summary>
        /// <remarks>
        /// International Customs document (International Transit by Road), issued by a guaranteeing association approved by the Customs authorities, under the cover of which goods are carried, in most cases under Customs seal, in road vehicles and/or containers in compliance with the requirements of the Customs TIR Convention of the International Transport of Goods under cover of TIR Carnets (UN/ECE).
        /// </remarks>
        TIRCarnet,

        /// <summary>
        /// EC carnet (Code: 953)
        /// </summary>
        /// <remarks>
        /// EC customs transit document issued by EC customs authorities for transit and/or temporary user of goods within the EC.
        /// </remarks>
        ECCarnet,

        /// <summary>
        /// EUR 1 certificate of origin (Code: 954)
        /// </summary>
        /// <remarks>
        /// Customs certificate used in preferential goods interchanges between EC countries and EC external countries.
        /// </remarks>
        EUR1CertificateOfOrigin,

        /// <summary>
        /// ATA carnet (Code: 955)
        /// </summary>
        /// <remarks>
        /// International Customs document (Admission Temporaire / Temporary Admission) which, issued under the terms of the ATA Convention (1961), incorporates an internationally valid guarantee and may be used, in lieu of national Customs documents and as security for import duties and taxes, to cover the temporary admission of goods and, where appropriate, the transit of goods. If accepted for controlling the temporary export and reimport of goods, international guarantee does not apply (CCC).
        /// </remarks>
        ATACarnet,

        /// <summary>
        /// Single administrative document (Code: 960)
        /// </summary>
        /// <remarks>
        /// A set of documents, replacing the various (national) forms for Customs declaration within the EC, implemented on 01-01-1988.
        /// </remarks>
        SingleAdministrativeDocument,

        /// <summary>
        /// General response (Customs) (Code: 961)
        /// </summary>
        /// <remarks>
        /// General response message to permit the transfer of data from Customs to the transmitter of the previous message.
        /// </remarks>
        GeneralResponseCustoms,

        /// <summary>
        /// Document response (Customs) (Code: 962)
        /// </summary>
        /// <remarks>
        /// Document response message to permit the transfer of data from Customs to the transmitter of the previous message.
        /// </remarks>
        DocumentResponseCustoms,

        /// <summary>
        /// Error response (Customs) (Code: 963)
        /// </summary>
        /// <remarks>
        /// Error response message to permit the transfer of data from Customs to the transmitter of the previous message.
        /// </remarks>
        ErrorResponseCustoms,

        /// <summary>
        /// Package response (Customs) (Code: 964)
        /// </summary>
        /// <remarks>
        /// Package response message to permit the transfer of data from Customs to the transmitter of the previous message.
        /// </remarks>
        PackageResponseCustoms,

        /// <summary>
        /// Tax calculation/confirmation response (Customs) (Code: 965)
        /// </summary>
        /// <remarks>
        /// Tax calculation/confirmation response message to permit the transfer of data from Customs to the transmitter of the previous message.
        /// </remarks>
        TaxCalculationconfirmationResponseCustoms,

        /// <summary>
        /// Quota prior allocation certificate (Code: 966)
        /// </summary>
        /// <remarks>
        /// Document/message issued by the competent body for prior allocation of a quota.
        /// </remarks>
        QuotaPriorAllocationCertificate,

        /// <summary>
        /// Wagon report (Code: 970)
        /// </summary>
        /// <remarks>
        /// Document which contains consignment information concerning the wagons and their lading in a case of a multiple wagon consignment.
        /// </remarks>
        WagonReport,

        /// <summary>
        /// Transit Conveyor Document (Code: 971)
        /// </summary>
        /// <remarks>
        /// Document for a course of transit used for a carrier who is neither the carrier at the beginning nor the arrival. The transit carrier can directly invoice the expenses for its part of the transport.
        /// </remarks>
        TransitConveyorDocument,

        /// <summary>
        /// Rail consignment note forwarder copy (Code: 972)
        /// </summary>
        /// <remarks>
        /// Document which is a copy of the rail consignment note printed especially for the need of the forwarder.
        /// </remarks>
        RailConsignmentNoteForwarderCopy,

        /// <summary>
        /// Duty suspended goods (Code: 974)
        /// </summary>
        /// <remarks>
        /// Document giving details for the carriage of excisable goods on a duty-suspended basis.
        /// </remarks>
        DutySuspendedGoods,

        /// <summary>
        /// Proof of transit declaration (Code: 975)
        /// </summary>
        /// <remarks>
        /// A document providing proof that a transit declaration has been accepted.
        /// </remarks>
        ProofOfTransitDeclaration,

        /// <summary>
        /// Container transfer note (Code: 976)
        /// </summary>
        /// <remarks>
        /// Document for the carriage of containers. Syn: transfer note.
        /// </remarks>
        ContainerTransferNote,

        /// <summary>
        /// NATO transit document (Code: 977)
        /// </summary>
        /// <remarks>
        /// Customs transit document for the carriage of shipments of the NATO armed forces under Customs supervision.
        /// </remarks>
        NATOTransitDocument,

        /// <summary>
        /// Transfrontier waste shipment authorization (Code: 978)
        /// </summary>
        /// <remarks>
        /// Document containing the authorization from the relevant authority for the international carriage of waste. Syn: Transfrontier waste shipment permit.
        /// </remarks>
        TransfrontierWasteShipmentAuthorization,

        /// <summary>
        /// Transfrontier waste shipment movement document (Code: 979)
        /// </summary>
        /// <remarks>
        /// Document certified by the carriers and the consignee to be used for the international carriage of waste.
        /// </remarks>
        TransfrontierWasteShipmentMovementDocument,

        /// <summary>
        /// End use authorization (Code: 990)
        /// </summary>
        /// <remarks>
        /// Document issued by Customs granting the end-use Customs procedure.
        /// </remarks>
        EndUseAuthorization,

        /// <summary>
        /// Government contract (Code: 991)
        /// </summary>
        /// <remarks>
        /// Document/message describing a contract with a government authority.
        /// </remarks>
        GovernmentContract,

        /// <summary>
        /// Statistical document, import (Code: 995)
        /// </summary>
        /// <remarks>
        /// Document/message describing an import document that is used for statistical purposes.
        /// </remarks>
        StatisticalDocumentimport,

        /// <summary>
        /// Application for documentary credit (Code: 996)
        /// </summary>
        /// <remarks>
        /// Message with application for opening of a documentary credit.
        /// </remarks>
        ApplicationForDocumentaryCredit,

        /// <summary>
        /// Previous Customs document/message (Code: 998)
        /// </summary>
        /// <remarks>
        /// Indication of the previous Customs document/message concerning the same transaction.
        /// </remarks>
        PreviousCustomsDocumentmessage,


    }
}