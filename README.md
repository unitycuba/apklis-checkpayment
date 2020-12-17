# Apklis Check Payment

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![Last commit](https://img.shields.io/github/last-commit/unitycuba/apklis-checkpayment.svg?style=flat)](https://github.com/unitycuba/apklis-checkpayment/commits)
[![GitHub commit activity](https://img.shields.io/github/commit-activity/m/unitycuba/apklis-checkpayment)](https://github.com/unitycuba/apklis-checkpayment/commits)
[![Github Stars](https://img.shields.io/github/stars/unitycuba/apklis-checkpayment?style=flat&logo=github)](https://github.com/unitycuba/apklis-checkpayment/stargazers)
[![Github Forks](https://img.shields.io/github/forks/unitycuba/apklis-checkpayment?style=flat&logo=github)](https://github.com/unitycuba/apklis-checkpayment/network/members)
[![Github Watchers](https://img.shields.io/github/watchers/unitycuba/apklis-checkpayment?style=flat&logo=github)](https://github.com/unitycuba/apklis-checkpayment)
[![GitHub contributors](https://img.shields.io/github/contributors/unitycuba/apklis-checkpayment)](https://github.com/unitycuba/apklis-checkpayment/graphs/contributors)

Este paquete tiene como objetivo conocer el estado de pago de una aplicación específica para el usuario logueado en la aplicación Apklis. Solo funciona para Android.

## Instalación

Se posible instalar desde el UPM: <https://docs.unity3d.com/Manual/upm-ui-giturl.html> usando la url <https://github.com/unitycuba/apklis-checkpayment.git>.

También se puede añadir agregando la siguiente línea al archivo `[Project Root]/Packages/manifest.json` como se explica en <https://docs.unity3d.com/Manual/upm-git.html>.

```json
"cu.unitycuba.apklischeckpayment": "https://github.com/unitycuba/apklis-checkpayment.git"
```

## Uso

Desde Unity es posible acceder a la clase `PaymentChecker` ubicada en `using Apklis.Payment;`. A continuación un ejemplo de uso:

```csharp
public bool CheckState()
{
    var result = PaymentChecker.IsPurchased(input.text);

    if (result.username == null)
        messageText.SetText("Por favor, autentifiquese en la aplicación de Apklis para seguir jugando");
    else if (!result.paid)
        messageText.SetText("Esta es pago, por favor, adquierala a través de Apklis");

    return result.paid;
}
```
