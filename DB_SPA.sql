/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     18/09/2019 18:19:43                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_RELATIONS_ROLE')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_RELATIONS_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_RELATIONS_TIME_WOR')
alter table BOOKING
   drop constraint FK_BOOKING_RELATIONS_TIME_WOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_RELATIONS_RECEIPT_')
alter table BOOKING
   drop constraint FK_BOOKING_RELATIONS_RECEIPT_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_RE_29_ACCOUNT')
alter table BOOKING
   drop constraint FK_BOOKING_RE_29_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_RE_32_ACCOUNT')
alter table BOOKING
   drop constraint FK_BOOKING_RE_32_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHAIR') and o.name = 'FK_CHAIR_RELATIONS_FLOOR')
alter table CHAIR
   drop constraint FK_CHAIR_RELATIONS_FLOOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_INGEDIENT') and o.name = 'FK_DETAIL_I_RELATIONS_INGREDIE')
alter table DETAIL_INGEDIENT
   drop constraint FK_DETAIL_I_RELATIONS_INGREDIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_INGEDIENT') and o.name = 'FK_DETAIL_I_RELATIONS_ITEM')
alter table DETAIL_INGEDIENT
   drop constraint FK_DETAIL_I_RELATIONS_ITEM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_RECEIPT') and o.name = 'FK_DETAIL_R_RELATIONS_RECEIPT')
alter table DETAIL_RECEIPT
   drop constraint FK_DETAIL_R_RELATIONS_RECEIPT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_RECEIPT') and o.name = 'FK_DETAIL_R_RELATIONS_ITEM')
alter table DETAIL_RECEIPT
   drop constraint FK_DETAIL_R_RELATIONS_ITEM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_RECEIPT_IMPORT') and o.name = 'FK_DETAIL_R_RE_12_ITEM')
alter table DETAIL_RECEIPT_IMPORT
   drop constraint FK_DETAIL_R_RE_12_ITEM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_RECEIPT_IMPORT') and o.name = 'FK_DETAIL_R_RE_13_RECEIPT_')
alter table DETAIL_RECEIPT_IMPORT
   drop constraint FK_DETAIL_R_RE_13_RECEIPT_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_RECEIPT_SERVICE') and o.name = 'FK_DETAIL_R_RELATIONS_SERVICE')
alter table DETAIL_RECEIPT_SERVICE
   drop constraint FK_DETAIL_R_RELATIONS_SERVICE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_RECEIPT_SERVICE') and o.name = 'FK_DETAIL_R_RELATIONS_ACCOUNT')
alter table DETAIL_RECEIPT_SERVICE
   drop constraint FK_DETAIL_R_RELATIONS_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETAIL_RECEIPT_SERVICE') and o.name = 'FK_DETAIL_R_RE_22_RECEIPT_')
alter table DETAIL_RECEIPT_SERVICE
   drop constraint FK_DETAIL_R_RE_22_RECEIPT_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FLOOR') and o.name = 'FK_FLOOR_RELATIONS_BRANCH')
alter table FLOOR
   drop constraint FK_FLOOR_RELATIONS_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEM') and o.name = 'FK_ITEM_RELATIONS_PRICE')
alter table ITEM
   drop constraint FK_ITEM_RELATIONS_PRICE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEM') and o.name = 'FK_ITEM_RELATIONS_TYPE_ITE')
alter table ITEM
   drop constraint FK_ITEM_RELATIONS_TYPE_ITE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEM') and o.name = 'FK_ITEM_RELATIONS_PRODUCER')
alter table ITEM
   drop constraint FK_ITEM_RELATIONS_PRODUCER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROFILE') and o.name = 'FK_PROFILE_RELATIONS_ACCOUNT')
alter table PROFILE
   drop constraint FK_PROFILE_RELATIONS_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROFILE_CUSTOMER') and o.name = 'FK_PROFILE__RELATIONS_PROFILE')
alter table PROFILE_CUSTOMER
   drop constraint FK_PROFILE__RELATIONS_PROFILE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROFILE_STAFF') and o.name = 'FK_PROFILE__RE_3_PROFILE')
alter table PROFILE_STAFF
   drop constraint FK_PROFILE__RE_3_PROFILE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECEIPT') and o.name = 'FK_RECEIPT_RE_14_ACCOUNT')
alter table RECEIPT
   drop constraint FK_RECEIPT_RE_14_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECEIPT') and o.name = 'FK_RECEIPT_RE_15_ACCOUNT')
alter table RECEIPT
   drop constraint FK_RECEIPT_RE_15_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECEIPT_IMPORT') and o.name = 'FK_RECEIPT__RELATIONS_SUPPLIER')
alter table RECEIPT_IMPORT
   drop constraint FK_RECEIPT__RELATIONS_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECEIPT_IMPORT') and o.name = 'FK_RECEIPT__RE_11_ACCOUNT')
alter table RECEIPT_IMPORT
   drop constraint FK_RECEIPT__RE_11_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECEIPT_SERVICE') and o.name = 'FK_RECEIPT__RELATIONS_CHAIR')
alter table RECEIPT_SERVICE
   drop constraint FK_RECEIPT__RELATIONS_CHAIR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECEIPT_SERVICE') and o.name = 'FK_RECEIPT__RE_19_ACCOUNT')
alter table RECEIPT_SERVICE
   drop constraint FK_RECEIPT__RE_19_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECEIPT_SERVICE') and o.name = 'FK_RECEIPT__RE_20_ACCOUNT')
alter table RECEIPT_SERVICE
   drop constraint FK_RECEIPT__RE_20_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SERVICE') and o.name = 'FK_SERVICE_RELATIONS_PRICE_SE')
alter table SERVICE
   drop constraint FK_SERVICE_RELATIONS_PRICE_SE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SERVICE') and o.name = 'FK_SERVICE_RELATIONS_INGREDIE')
alter table SERVICE
   drop constraint FK_SERVICE_RELATIONS_INGREDIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TIMEKEEPING') and o.name = 'FK_TIMEKEEP_RELATIONS_ACCOUNT')
alter table TIMEKEEPING
   drop constraint FK_TIMEKEEP_RELATIONS_ACCOUNT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'RELATIONSHIP_32_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.RELATIONSHIP_32_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'RELATIONSHIP_31_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.RELATIONSHIP_31_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'RELATIONSHIP_30_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.RELATIONSHIP_30_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'RELATIONSHIP_29_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.RELATIONSHIP_29_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKING')
            and   type = 'U')
   drop table BOOKING
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHAIR')
            and   name  = 'RELATIONSHIP_34_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHAIR.RELATIONSHIP_34_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHAIR')
            and   type = 'U')
   drop table CHAIR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"CONVERT"')
            and   type = 'U')
   drop table "CONVERT"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_INGEDIENT')
            and   name  = 'RELATIONSHIP_26_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_INGEDIENT.RELATIONSHIP_26_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_INGEDIENT')
            and   name  = 'RELATIONSHIP_25_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_INGEDIENT.RELATIONSHIP_25_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETAIL_INGEDIENT')
            and   type = 'U')
   drop table DETAIL_INGEDIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_RECEIPT')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_RECEIPT.RELATIONSHIP_17_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_RECEIPT')
            and   name  = 'RELATIONSHIP_16_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_RECEIPT.RELATIONSHIP_16_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETAIL_RECEIPT')
            and   type = 'U')
   drop table DETAIL_RECEIPT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_RECEIPT_IMPORT')
            and   name  = 'RELATIONSHIP_13_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_RECEIPT_IMPORT.RELATIONSHIP_13_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_RECEIPT_IMPORT')
            and   name  = 'RELATIONSHIP_12_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_RECEIPT_IMPORT.RELATIONSHIP_12_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETAIL_RECEIPT_IMPORT')
            and   type = 'U')
   drop table DETAIL_RECEIPT_IMPORT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_RECEIPT_SERVICE')
            and   name  = 'RELATIONSHIP_27_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_RECEIPT_SERVICE.RELATIONSHIP_27_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_RECEIPT_SERVICE')
            and   name  = 'RELATIONSHIP_23_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_RECEIPT_SERVICE.RELATIONSHIP_23_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETAIL_RECEIPT_SERVICE')
            and   name  = 'RELATIONSHIP_22_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETAIL_RECEIPT_SERVICE.RELATIONSHIP_22_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETAIL_RECEIPT_SERVICE')
            and   type = 'U')
   drop table DETAIL_RECEIPT_SERVICE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLOOR')
            and   name  = 'RELATIONSHIP_33_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLOOR.RELATIONSHIP_33_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLOOR')
            and   type = 'U')
   drop table FLOOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INGREDIENT')
            and   type = 'U')
   drop table INGREDIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ITEM')
            and   name  = 'RELATIONSHIP_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index ITEM.RELATIONSHIP_8_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ITEM')
            and   name  = 'RELATIONSHIP_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index ITEM.RELATIONSHIP_7_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ITEM')
            and   name  = 'RELATIONSHIP_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index ITEM.RELATIONSHIP_6_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEM')
            and   type = 'U')
   drop table ITEM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRICE')
            and   type = 'U')
   drop table PRICE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRICE_SERVICE')
            and   type = 'U')
   drop table PRICE_SERVICE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCER')
            and   type = 'U')
   drop table PRODUCER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROFILE')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROFILE.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROFILE')
            and   type = 'U')
   drop table PROFILE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROFILE_CUSTOMER')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROFILE_CUSTOMER.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROFILE_CUSTOMER')
            and   type = 'U')
   drop table PROFILE_CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PROFILE_STAFF')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index PROFILE_STAFF.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROFILE_STAFF')
            and   type = 'U')
   drop table PROFILE_STAFF
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RECEIPT')
            and   name  = 'RELATIONSHIP_15_FK'
            and   indid > 0
            and   indid < 255)
   drop index RECEIPT.RELATIONSHIP_15_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RECEIPT')
            and   name  = 'RELATIONSHIP_14_FK'
            and   indid > 0
            and   indid < 255)
   drop index RECEIPT.RELATIONSHIP_14_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RECEIPT')
            and   type = 'U')
   drop table RECEIPT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RECEIPT_IMPORT')
            and   name  = 'RELATIONSHIP_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index RECEIPT_IMPORT.RELATIONSHIP_11_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RECEIPT_IMPORT')
            and   name  = 'RELATIONSHIP_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index RECEIPT_IMPORT.RELATIONSHIP_10_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RECEIPT_IMPORT')
            and   type = 'U')
   drop table RECEIPT_IMPORT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RECEIPT_SERVICE')
            and   name  = 'RELATIONSHIP_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index RECEIPT_SERVICE.RELATIONSHIP_35_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RECEIPT_SERVICE')
            and   name  = 'RELATIONSHIP_20_FK'
            and   indid > 0
            and   indid < 255)
   drop index RECEIPT_SERVICE.RELATIONSHIP_20_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RECEIPT_SERVICE')
            and   name  = 'RELATIONSHIP_19_FK'
            and   indid > 0
            and   indid < 255)
   drop index RECEIPT_SERVICE.RELATIONSHIP_19_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RECEIPT_SERVICE')
            and   type = 'U')
   drop table RECEIPT_SERVICE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROLE')
            and   type = 'U')
   drop table ROLE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SERVICE')
            and   name  = 'RELATIONSHIP_24_FK'
            and   indid > 0
            and   indid < 255)
   drop index SERVICE.RELATIONSHIP_24_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SERVICE')
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index SERVICE.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SERVICE')
            and   type = 'U')
   drop table SERVICE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPPLIER')
            and   type = 'U')
   drop table SUPPLIER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIMEKEEPING')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index TIMEKEEPING.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIMEKEEPING')
            and   type = 'U')
   drop table TIMEKEEPING
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIME_WORKER')
            and   type = 'U')
   drop table TIME_WORKER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TYPE_ITEM')
            and   type = 'U')
   drop table TYPE_ITEM
go

/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   ID_USER              int                  not null,
   ID_ROLE              int                  null,
   USERNAME             varchar(50)          null,
   PASSWORD             varchar(50)          null,
   STATUS               int                  null,
   constraint PK_ACCOUNT primary key (ID_USER)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_1_FK on ACCOUNT (ID_ROLE ASC)
go

/*==============================================================*/
/* Table: BOOKING                                               */
/*==============================================================*/
create table BOOKING (
   ID_BOOKING           int                  not null,
   ID_RECEIPT_SERVICE   int                  null,
   ID_USER_CUSTOMER     int                  null,
   ID_USER_WORKER       int                  null,
   ID_TIME_WORKER       int                  null,
   BOOK_DATE            datetime             null,
   STATUS               int                  null,
   constraint PK_BOOKING primary key (ID_BOOKING)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_29_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_29_FK on BOOKING (ID_USER_CUSTOMER ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_30_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_30_FK on BOOKING (ID_TIME_WORKER ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_31_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_31_FK on BOOKING (ID_RECEIPT_SERVICE ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_32_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_32_FK on BOOKING (ID_USER_WORKER ASC)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   ID_BRANCH            int                  not null,
   NAME_BRANCH          varchar(500)         null,
   ADDRESS              varchar(250)         null,
   CREATE_AT            datetime             null,
   PHONE                char(10)             null,
   STATUS               int                  null,
   constraint PK_BRANCH primary key (ID_BRANCH)
)
go

/*==============================================================*/
/* Table: CHAIR                                                 */
/*==============================================================*/
create table CHAIR (
   ID_CHAIR             int                  not null,
   ID_FLOOR             int                  null,
   NAME                 varchar(250)         null,
   STATUS               int                  null,
   constraint PK_CHAIR primary key (ID_CHAIR)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_34_FK on CHAIR (ID_FLOOR ASC)
go

/*==============================================================*/
/* Table: "CONVERT"                                             */
/*==============================================================*/
create table "CONVERT" (
   ID_CONVERT           int                  not null,
   NAME_UNIT_BEFORE     varchar(50)          null,
   NUMBER_BEFORE        float                null,
   NAME_UNIT_AFTER      varchar(50)          null,
   NUMBER_AFTER         float                null,
   STATUS               int                  null,
   constraint PK_CONVERT primary key (ID_CONVERT)
)
go

/*==============================================================*/
/* Table: DETAIL_INGEDIENT                                      */
/*==============================================================*/
create table DETAIL_INGEDIENT (
   ID_DETAIL_INGREDIENT int                  not null,
   ID_INGREDIENT        int                  null,
   ID_ITEM              int                  null,
   NUMBER               int                  null,
   UNIT_INGRE           varchar(50)          null,
   STATUS               int                  null,
   constraint PK_DETAIL_INGEDIENT primary key (ID_DETAIL_INGREDIENT)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_25_FK on DETAIL_INGEDIENT (ID_INGREDIENT ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_26_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_26_FK on DETAIL_INGEDIENT (ID_ITEM ASC)
go

/*==============================================================*/
/* Table: DETAIL_RECEIPT                                        */
/*==============================================================*/
create table DETAIL_RECEIPT (
   ID_DETAIL_RECEIPT    int                  not null,
   ID_RECEIPT           int                  null,
   ID_ITEM              int                  null,
   NUMBER               int                  null,
   STATUS               int                  null,
   constraint PK_DETAIL_RECEIPT primary key (ID_DETAIL_RECEIPT)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_16_FK on DETAIL_RECEIPT (ID_RECEIPT ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_17_FK on DETAIL_RECEIPT (ID_ITEM ASC)
go

/*==============================================================*/
/* Table: DETAIL_RECEIPT_IMPORT                                 */
/*==============================================================*/
create table DETAIL_RECEIPT_IMPORT (
   ID_DETAIL_RECEIPT_IMPORT int                  not null,
   ID_RECEPT_IMPORT     int                  null,
   ID_ITEM              int                  null,
   NUMBER               int                  null,
   STATUS               int                  null,
   constraint PK_DETAIL_RECEIPT_IMPORT primary key (ID_DETAIL_RECEIPT_IMPORT)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_12_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_12_FK on DETAIL_RECEIPT_IMPORT (ID_ITEM ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_13_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_13_FK on DETAIL_RECEIPT_IMPORT (ID_RECEPT_IMPORT ASC)
go

/*==============================================================*/
/* Table: DETAIL_RECEIPT_SERVICE                                */
/*==============================================================*/
create table DETAIL_RECEIPT_SERVICE (
   ID_DETAIL_RECEIPT_SERVICE int                  not null,
   ID_SERVICE           int                  null,
   ID_USER_WORKER       int                  null,
   ID_RECEIPT_SERVICE   int                  null,
   CREATE_AT            datetime             null,
   STATUS               int                  null,
   constraint PK_DETAIL_RECEIPT_SERVICE primary key (ID_DETAIL_RECEIPT_SERVICE)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_22_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_22_FK on DETAIL_RECEIPT_SERVICE (ID_RECEIPT_SERVICE ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_23_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_23_FK on DETAIL_RECEIPT_SERVICE (ID_SERVICE ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_27_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_27_FK on DETAIL_RECEIPT_SERVICE (ID_USER_WORKER ASC)
go

/*==============================================================*/
/* Table: FLOOR                                                 */
/*==============================================================*/
create table FLOOR (
   ID_FLOOR             int                  not null,
   ID_BRANCH            int                  null,
   NAME                 varchar(250)         null,
   STATUS               int                  null,
   constraint PK_FLOOR primary key (ID_FLOOR)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_33_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_33_FK on FLOOR (ID_BRANCH ASC)
go

/*==============================================================*/
/* Table: INGREDIENT                                            */
/*==============================================================*/
create table INGREDIENT (
   ID_INGREDIENT        int                  not null,
   CREATE_AT            datetime             null,
   STATUS               int                  null,
   constraint PK_INGREDIENT primary key (ID_INGREDIENT)
)
go

/*==============================================================*/
/* Table: ITEM                                                  */
/*==============================================================*/
create table ITEM (
   ID_ITEM              int                  not null,
   ID_PRODUCER          int                  null,
   ID_PRICE             int                  null,
   ID_TYPE              int                  null,
   NAME_ITEM            varchar(250)         null,
   UNIT                 varchar(50)          null,
   DEADLINE             datetime             null,
   DETAIL               text                 null,
   STATUS               int                  null,
   constraint PK_ITEM primary key (ID_ITEM)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_6_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_6_FK on ITEM (ID_PRICE ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_7_FK on ITEM (ID_TYPE ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_8_FK on ITEM (ID_PRODUCER ASC)
go

/*==============================================================*/
/* Table: PRICE                                                 */
/*==============================================================*/
create table PRICE (
   ID_PRICE             int                  not null,
   PRICE                float                null,
   TYPE                 varchar(10)          null,
   CREATE_AT            datetime             null,
   STATUS               int                  null,
   constraint PK_PRICE primary key (ID_PRICE)
)
go

/*==============================================================*/
/* Table: PRICE_SERVICE                                         */
/*==============================================================*/
create table PRICE_SERVICE (
   ID_PRICE_SERVICE     int                  not null,
   PRICE                float                null,
   CREATE_AT            datetime             null,
   STATUS               int                  null,
   constraint PK_PRICE_SERVICE primary key (ID_PRICE_SERVICE)
)
go

/*==============================================================*/
/* Table: PRODUCER                                              */
/*==============================================================*/
create table PRODUCER (
   ID_PRODUCER          int                  not null,
   CODE_PRODUCER        varchar(50)          null,
   NAME_PRODUCER        varchar(100)         null,
   ADDRESS              varchar(250)         null,
   PHONE                char(10)             null,
   EMAIL                varchar(50)          null,
   WEBSITE              varchar(500)         null,
   STATUS               int                  null,
   constraint PK_PRODUCER primary key (ID_PRODUCER)
)
go

/*==============================================================*/
/* Table: PROFILE                                               */
/*==============================================================*/
create table PROFILE (
   ID_PROFILE           int                  not null,
   ID_USER              int                  null,
   IDENFITICATION       varchar(12)          null,
   LAST_NAME            varchar(50)          null,
   FIRST_NAME           varchar(50)          null,
   SEX                  varchar(5)           null,
   PHONE                char(10)             null,
   ADDRESS              varchar(250)         null,
   STATUS               int                  null,
   constraint PK_PROFILE primary key (ID_PROFILE)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_2_FK on PROFILE (ID_USER ASC)
go

/*==============================================================*/
/* Table: PROFILE_CUSTOMER                                      */
/*==============================================================*/
create table PROFILE_CUSTOMER (
   ID_PROFILE_CUSTOMER  int                  not null,
   ID_PROFILE           int                  null,
   TYPE                 varchar(10)          null,
   SCORE                int                  null,
   constraint PK_PROFILE_CUSTOMER primary key (ID_PROFILE_CUSTOMER)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_4_FK on PROFILE_CUSTOMER (ID_PROFILE ASC)
go

/*==============================================================*/
/* Table: PROFILE_STAFF                                         */
/*==============================================================*/
create table PROFILE_STAFF (
   ID_PROFILE_STAFF     int                  not null,
   ID_PROFILE           int                  null,
   POSITION             varchar(50)          null,
   constraint PK_PROFILE_STAFF primary key (ID_PROFILE_STAFF)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_3_FK on PROFILE_STAFF (ID_PROFILE ASC)
go

/*==============================================================*/
/* Table: RECEIPT                                               */
/*==============================================================*/
create table RECEIPT (
   ID_RECEIPT           int                  not null,
   ID_USER_STAFF        int                  null,
   ID_USER_CUSTOMER     int                  null,
   CODE_RECEIPT         varchar(50)          null,
   CREATE_AT            datetime             null,
   SUM_MONEY            float                null,
   STATUS               int                  null,
   constraint PK_RECEIPT primary key (ID_RECEIPT)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_14_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_14_FK on RECEIPT (ID_USER_CUSTOMER ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_15_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_15_FK on RECEIPT (ID_USER_STAFF ASC)
go

/*==============================================================*/
/* Table: RECEIPT_IMPORT                                        */
/*==============================================================*/
create table RECEIPT_IMPORT (
   ID_RECEPT_IMPORT     int                  not null,
   ID_USER              int                  null,
   ID_SUPPIER           int                  null,
   CODE_IMPORT          varchar(50)          null,
   CREATE_AT            datetime             null,
   SUM_MONEY            float                null,
   STATUS               int                  null,
   constraint PK_RECEIPT_IMPORT primary key (ID_RECEPT_IMPORT)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_10_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_10_FK on RECEIPT_IMPORT (ID_SUPPIER ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_11_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_11_FK on RECEIPT_IMPORT (ID_USER ASC)
go

/*==============================================================*/
/* Table: RECEIPT_SERVICE                                       */
/*==============================================================*/
create table RECEIPT_SERVICE (
   ID_RECEIPT_SERVICE   int                  not null,
   ID_USER_STAFF        int                  null,
   ID_CHAIR             int                  null,
   ID_USER_CUSTOMER     int                  null,
   CREATE_AT            datetime             null,
   SUM_MONEY            float                null,
   STATUS               int                  null,
   constraint PK_RECEIPT_SERVICE primary key (ID_RECEIPT_SERVICE)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_19_FK on RECEIPT_SERVICE (ID_USER_CUSTOMER ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_20_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_20_FK on RECEIPT_SERVICE (ID_USER_STAFF ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_35_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_35_FK on RECEIPT_SERVICE (ID_CHAIR ASC)
go

/*==============================================================*/
/* Table: ROLE                                                  */
/*==============================================================*/
create table ROLE (
   ID_ROLE              int                  not null,
   NAME_ROLE            varchar(50)          null,
   STATUS               int                  null,
   constraint PK_ROLE primary key (ID_ROLE)
)
go

/*==============================================================*/
/* Table: SERVICE                                               */
/*==============================================================*/
create table SERVICE (
   ID_SERVICE           int                  not null,
   ID_INGREDIENT        int                  null,
   ID_PRICE_SERVICE     int                  null,
   NAME                 varchar(250)         null,
   DETAIL               text                 null,
   STATUS               int                  null,
   constraint PK_SERVICE primary key (ID_SERVICE)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_18_FK on SERVICE (ID_PRICE_SERVICE ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_24_FK on SERVICE (ID_INGREDIENT ASC)
go

/*==============================================================*/
/* Table: SUPPLIER                                              */
/*==============================================================*/
create table SUPPLIER (
   ID_SUPPIER           int                  not null,
   NAME_SUPPLIER        varchar(250)         null,
   ADDRESS              varchar(250)         null,
   PHONE                char(10)             null,
   EMAIL                varchar(50)          null,
   STATUS               int                  null,
   constraint PK_SUPPLIER primary key (ID_SUPPIER)
)
go

/*==============================================================*/
/* Table: TIMEKEEPING                                           */
/*==============================================================*/
create table TIMEKEEPING (
   ID_TIME              int                  not null,
   ID_USER              int                  null,
   DATE                 datetime             null,
   SHIFT                int                  null,
   STATUS               int                  null,
   constraint PK_TIMEKEEPING primary key (ID_TIME)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_5_FK on TIMEKEEPING (ID_USER ASC)
go

/*==============================================================*/
/* Table: TIME_WORKER                                           */
/*==============================================================*/
create table TIME_WORKER (
   ID_TIME_WORKER       int                  not null,
   SHIFT                int                  null,
   TIME                 datetime             null,
   STATUS               int                  null,
   constraint PK_TIME_WORKER primary key (ID_TIME_WORKER)
)
go

/*==============================================================*/
/* Table: TYPE_ITEM                                             */
/*==============================================================*/
create table TYPE_ITEM (
   ID_TYPE              int                  not null,
   NAME_TYPE            varchar(100)         null,
   STATUS               int                  null,
   constraint PK_TYPE_ITEM primary key (ID_TYPE)
)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_RELATIONS_ROLE foreign key (ID_ROLE)
      references ROLE (ID_ROLE)
go

alter table BOOKING
   add constraint FK_BOOKING_RELATIONS_TIME_WOR foreign key (ID_TIME_WORKER)
      references TIME_WORKER (ID_TIME_WORKER)
go

alter table BOOKING
   add constraint FK_BOOKING_RELATIONS_RECEIPT_ foreign key (ID_RECEIPT_SERVICE)
      references RECEIPT_SERVICE (ID_RECEIPT_SERVICE)
go

alter table BOOKING
   add constraint FK_BOOKING_RE_29_ACCOUNT foreign key (ID_USER_CUSTOMER)
      references ACCOUNT (ID_USER)
go

alter table BOOKING
   add constraint FK_BOOKING_RE_32_ACCOUNT foreign key (ID_USER_WORKER)
      references ACCOUNT (ID_USER)
go

alter table CHAIR
   add constraint FK_CHAIR_RELATIONS_FLOOR foreign key (ID_FLOOR)
      references FLOOR (ID_FLOOR)
go

alter table DETAIL_INGEDIENT
   add constraint FK_DETAIL_I_RELATIONS_INGREDIE foreign key (ID_INGREDIENT)
      references INGREDIENT (ID_INGREDIENT)
go

alter table DETAIL_INGEDIENT
   add constraint FK_DETAIL_I_RELATIONS_ITEM foreign key (ID_ITEM)
      references ITEM (ID_ITEM)
go

alter table DETAIL_RECEIPT
   add constraint FK_DETAIL_R_RELATIONS_RECEIPT foreign key (ID_RECEIPT)
      references RECEIPT (ID_RECEIPT)
go

alter table DETAIL_RECEIPT
   add constraint FK_DETAIL_R_RELATIONS_ITEM foreign key (ID_ITEM)
      references ITEM (ID_ITEM)
go

alter table DETAIL_RECEIPT_IMPORT
   add constraint FK_DETAIL_R_RE_12_ITEM foreign key (ID_ITEM)
      references ITEM (ID_ITEM)
go

alter table DETAIL_RECEIPT_IMPORT
   add constraint FK_DETAIL_R_RE_13_RECEIPT_ foreign key (ID_RECEPT_IMPORT)
      references RECEIPT_IMPORT (ID_RECEPT_IMPORT)
go

alter table DETAIL_RECEIPT_SERVICE
   add constraint FK_DETAIL_R_RELATIONS_SERVICE foreign key (ID_SERVICE)
      references SERVICE (ID_SERVICE)
go

alter table DETAIL_RECEIPT_SERVICE
   add constraint FK_DETAIL_R_RELATIONS_ACCOUNT foreign key (ID_USER_WORKER)
      references ACCOUNT (ID_USER)
go

alter table DETAIL_RECEIPT_SERVICE
   add constraint FK_DETAIL_R_RE_22_RECEIPT_ foreign key (ID_RECEIPT_SERVICE)
      references RECEIPT_SERVICE (ID_RECEIPT_SERVICE)
go

alter table FLOOR
   add constraint FK_FLOOR_RELATIONS_BRANCH foreign key (ID_BRANCH)
      references BRANCH (ID_BRANCH)
go

alter table ITEM
   add constraint FK_ITEM_RELATIONS_PRICE foreign key (ID_PRICE)
      references PRICE (ID_PRICE)
go

alter table ITEM
   add constraint FK_ITEM_RELATIONS_TYPE_ITE foreign key (ID_TYPE)
      references TYPE_ITEM (ID_TYPE)
go

alter table ITEM
   add constraint FK_ITEM_RELATIONS_PRODUCER foreign key (ID_PRODUCER)
      references PRODUCER (ID_PRODUCER)
go

alter table PROFILE
   add constraint FK_PROFILE_RELATIONS_ACCOUNT foreign key (ID_USER)
      references ACCOUNT (ID_USER)
go

alter table PROFILE_CUSTOMER
   add constraint FK_PROFILE__RELATIONS_PROFILE foreign key (ID_PROFILE)
      references PROFILE (ID_PROFILE)
go

alter table PROFILE_STAFF
   add constraint FK_PROFILE__RE_3_PROFILE foreign key (ID_PROFILE)
      references PROFILE (ID_PROFILE)
go

alter table RECEIPT
   add constraint FK_RECEIPT_RE_14_ACCOUNT foreign key (ID_USER_CUSTOMER)
      references ACCOUNT (ID_USER)
go

alter table RECEIPT
   add constraint FK_RECEIPT_RE_15_ACCOUNT foreign key (ID_USER_STAFF)
      references ACCOUNT (ID_USER)
go

alter table RECEIPT_IMPORT
   add constraint FK_RECEIPT__RELATIONS_SUPPLIER foreign key (ID_SUPPIER)
      references SUPPLIER (ID_SUPPIER)
go

alter table RECEIPT_IMPORT
   add constraint FK_RECEIPT__RE_11_ACCOUNT foreign key (ID_USER)
      references ACCOUNT (ID_USER)
go

alter table RECEIPT_SERVICE
   add constraint FK_RECEIPT__RELATIONS_CHAIR foreign key (ID_CHAIR)
      references CHAIR (ID_CHAIR)
go

alter table RECEIPT_SERVICE
   add constraint FK_RECEIPT__RE_19_ACCOUNT foreign key (ID_USER_CUSTOMER)
      references ACCOUNT (ID_USER)
go

alter table RECEIPT_SERVICE
   add constraint FK_RECEIPT__RE_20_ACCOUNT foreign key (ID_USER_STAFF)
      references ACCOUNT (ID_USER)
go

alter table SERVICE
   add constraint FK_SERVICE_RELATIONS_PRICE_SE foreign key (ID_PRICE_SERVICE)
      references PRICE_SERVICE (ID_PRICE_SERVICE)
go

alter table SERVICE
   add constraint FK_SERVICE_RELATIONS_INGREDIE foreign key (ID_INGREDIENT)
      references INGREDIENT (ID_INGREDIENT)
go

alter table TIMEKEEPING
   add constraint FK_TIMEKEEP_RELATIONS_ACCOUNT foreign key (ID_USER)
      references ACCOUNT (ID_USER)
go

