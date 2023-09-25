![SnowTraceApi.Net](https://github.com/emin-karadag/SnowTraceApi.Net/blob/main/SnowTraceApi.Net/SnowTrace-Vertical-Logo.svg)

## SnowTraceApi.Net
SnowTraceApi.NET, yazılım geliştiricilerin "Avalance C-Chain" gezginine API üzerinden erişim sağlayıp blokzincir verilerine ulaşmasını sağlayan bir .NET kütüphanesidir. 


SnowTrace'in herkese açık [API dokümanı](https://docs.snowtrace.io/) referans alınarak C# programlama dili ile geliştirilmiştir.

### Lisans: 
    MIT License

## Özellikleri
- NuGet aracılığıyla yükleyebilme. ([SnowTraceApi.Net](https://www.nuget.org/packages/SnowTraceApi.Net))
- .NET 7 desteği. (Linux/MacOS uyumluluğu)
- RestAPI, [SnowTrace resmi dokümanının](https://docs.snowtrace.io/) büyük çoğunluğunu destekler.
	- Aktif olarak yeni özellikler eklenmeye devam edilecek.

## Başlangıç
API uç noktalarını kullanabilmek için SnowTrace hesabı oluşturmanız gerekmektedir. 
> Eğer hesabınız yok ise [buraya tıklayarak](https://snowtrace.io/register) SnowTrace'e kaydolabilirsiniz.

## Kurulum
Bu kütüphane NuGet'te mevcuttur, indirmek için çekinmeyin. ([https://www.nuget.org/packages/SnowTraceApi.Net](https://www.nuget.org/packages/SnowTraceApi.Net "[https://www.nuget.org/packages/SnowTraceApi.Net](https://www.nuget.org/packages/SnowTraceApi.Net)"))

**NuGet PM**
```
Install-Package SnowTraceApi.Net -Version 1.0.0
```

**dotnet cli**
```
dotnet add package SnowTraceApi.Net --version 1.0.0
```
<!--
## Yol Haritası
Önümüzdeki süreçte `BinanceTR` kütüphanesine yeni özelliklerin eklenmesi ve genişletilmesi için çalışmalar yapılacaktır. Aşağıdaki tabloda üzerinde çalıştığımız yeni özellikleri görebilirsiniz.

| Özellik                 |    Durum     |  
|------------------------|:--------------:|
| OCO (Order-Cancel-Order) Desteği            |      ✔         |
| Hesap Ticaret Listesi (Account trade list)    |                |
| Para Çekme Talebi (Withdraw)                    |                |
| Para Çekme Geçmişi (Withdraw History)    |                |
| Para Yatırma Geçmişi (Deposit History)      |                |
| Para Yatırma Adresi (Deposit Address)       |                | |

!-->
## Örnek Kullanım

**Bağımlılık Enjeksiyonu (Dependency Injection):**
```csharp
using SnowTraceApi.Net.Business.Abstract;
using SnowTraceApi.Net.Business.Concrete;

services.AddSingleton<ISnowTraceService, SnowTraceManager>();
```

**Constructor'da tanımalama:**
```csharp
using SnowTraceApi.Net.Business.Abstract;

private readonly ISnowTraceService _snowTraceService;
public Test(ISnowTraceService snowTraceService)
{
   _snowTraceService = snowTraceService;
}
```

------------


**1. Web3 cüzdanındaki AVAX bakiyesini okuma:**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var address = "0x4aeFa39caEAdD662aE31ab0CE7c8C2c9c0a013E8";
var result = await _snowTraceService.AccountsApi.GetAvaxBalanceForSingleAddressAsync(apiKey, address, ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------

**2. Birden fazla Web3 cüzdanındaki AVAX bakiyelerini okuma:**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var addresses = new List<string> { "0x4aeFa39caEAdD662aE31ab0CE7c8C2c9c0a013E8", "0xefdc8FC1145ea88e3f5698eE7b7b432F083B4246" };
var result = await _snowTraceService.AccountsApi.GetAvaxBalanceForMultipleAddressesAsync(apiKey, addresses, ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------

**3. Bir cüzdana ait 'Normal' işlem geçmişini okuma:**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var address = "0x4aeFa39caEAdD662aE31ab0CE7c8C2c9c0a013E8";
var result = await _snowTraceService.AccountsApi.GetNormalTransactionsByAddressAsync(apiKey, address, ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------

**4. Bir cüzdana ait 'Dahili' işlem geçmişini okuma::**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var address = "0x4aeFa39caEAdD662aE31ab0CE7c8C2c9c0a013E8";
var result = await _snowTraceService.AccountsApi.GetInternalTransactionsByAddressAsync(apiKey, address, ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------

**5. 'Hash' bilgisine göre dahili bir transfer bilgisi okuma:**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var hash = "0x8ee0cb790486eac134f55c736e7d6ac7dada705035ddab3fae67aee5ce1ec6bf";
var result = await _snowTraceService.AccountsApi.GetInternalTransactionsByHashAsync(apiKey, hash, ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------

**6. Bir blok aralığında gerçekleştirilen işlemleri okuma:**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var result = await _snowTraceService.AccountsApi.GetInternalTransactionsByBlockRangeAsync(apiKey, startBlock: 10, endBlock: 100, sort: "desc", ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------

**7. Sözleşme adresine göre belirli bir ERC-20 token transfer işlemlerini görüntüleme:**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var address = "0xdc54a239B3be06E63b0DecA16c373d4480820498";
var contractAddress = "0x9702230A8Ea53601f5cD2dc00fDBc13d4dF4A8c7";
var result = await _snowTraceService.AccountsApi.GetTokenTransferEventsByAddressAsync(apiKey, address, contractAddress, ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------

**8.  Sözleşme adresine göre belirli birERC-721 (NFT) transfer işlemlerini görüntüleme:**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var address = "0xdc54a239B3be06E63b0DecA16c373d4480820498";
var contractAddress = "0xA9D5c7d0173f09FB4ed36ab8dD0BaFc9110733B5";
var result = await _snowTraceService.AccountsApi.GetNftTransferEventsByAddressAsync(apiKey, address, contractAddress, ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------

**9.  Bir adres tarafından çıkartılan blokların listesini görüntüleme:**
```csharp
var apiKey = "xx_snowtrace_api_key_xx";
var address = "0xdc54a239B3be06E63b0DecA16c373d4480820498";
var result = await _snowTraceService.AccountsApi.GetBlockMinedByAddressAsync(apiKey, address, ct: stoppingToken);
if (result.Success)
{
    // ...
}
```

------------



## Bağış Yap
Kütüphaneyi kullanıp beğendiyseniz destek olmak amaçlı bağışta bulunabilirsiniz. Aşağıda Bitcoin ve Ethereum için cüzdan adreslerim yer almaktadır.

<img src="https://cdn.worldvectorlogo.com/logos/tether-1.svg" width="24px"> **Tether (USDT) - TRC20:** `TC3ruh9qWbwAnCHGEkschnmcYUNxGumHJS`

<img src="https://cdn.worldvectorlogo.com/logos/bitcoin.svg" width="24px"> **Bitcoin (BTC) - ERC20:** `0x4a656a72fada0ccdef737ad8cc2e39686af5efbe`

<img src="https://cdn.worldvectorlogo.com/logos/ethereum-1.svg" width="18px"> **Ethereum - ETH:** `0x4a656a72fada0ccdef737ad8cc2e39686af5efbe`
