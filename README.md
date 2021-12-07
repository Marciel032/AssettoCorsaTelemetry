# Assetto Corsa Telemetry

![GitHub code size](https://img.shields.io/github/languages/code-size/marciel032/AssettoCorsaTelemetry?style=for-the-badge)
![GitHub forks](https://img.shields.io/github/forks/marciel032/AssettoCorsaTelemetry?style=for-the-badge)
![GitHub pull requests](https://img.shields.io/github/issues-pr-raw/marciel032/AssettoCorsaTelemetry?style=for-the-badge)
![GitHub closed pull requests](https://img.shields.io/github/issues-pr-closed-raw/marciel032/AssettoCorsaTelemetry?style=for-the-badge)
![GitHub contributors](https://img.shields.io/github/contributors/marciel032/AssettoCorsaTelemetry?style=for-the-badge)


> This project allows reading data from assetto corsa and assetto corsa competizione


## 💻 Prerequisites

Before starting, make sure you have met the following requirements:
* Use Visual studio 2019 to compile the Demo.

## ☕ Using

Start the telemetry reader
```csharp
telemetryReader = new AssettoCorsaTelemetryReader();
telemetryReader.OnTelemetryRead += TelemetryReader_OnTelemetryRead;
```

The event OnTelemetryRead is called on new information is writed
```csharp
private void TelemetryReader_OnTelemetryRead(AssettoCorsaTelemetry telemetry)
{
    ...
}
```

Use the demo project to more reference.

## 💾 Games suported

* Assetto Corsa Competizione - from main branch
* Assetto Corsa - from branch "AssettoCorsa"


## 📫 Contributing to the project
To contribute, follow these steps:

1. Fork this repository.
2. Create a branch.
3. Make your changes and commit them.
4. Send to original branch.
5. Create the pull request.

Alternatively, see the GitHub documentation at [how to create a pull request](https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/creating-a-pull-request).


## 🤝 Colaboradores

We thank the following people who contributed to this project:

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Marciel032">
        <img src="https://avatars3.githubusercontent.com/Marciel032" width="100px;" alt="Marciel Grützmann"/><br>
        <sub>
          <b>Marciel Grützmann</b>
        </sub>
      </a>
    </td>   
    <td align="center">
      <a href="https://github.com/mdjarv">
        <img src="https://avatars3.githubusercontent.com/mdjarv" width="100px;" alt="Mathias Djärv"/><br>
        <sub>
          <b>Mathias Djärv</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/donald-42">
        <img src="https://avatars3.githubusercontent.com/donald-42" width="100px;" alt="donald-42"/><br>
        <sub>
          <b>donald-42</b>
        </sub>
      </a>
    </td>
  </tr>
</table>

## 📘 References 
#### [AC docs](https://www.assettocorsa.net/forum/index.php?threads/shared-memory-reference-25-05-2017.3352/)
#### [ACC docs](https://www.assettocorsa.net/forum/index.php?threads/acc-shared-memory-documentation.59965/)
#### [Original Assetto Corsa project from mdjarv](https://github.com/mdjarv/assettocorsasharedmemory)
#### [Original Assetto Corsa Competizione project from donald-42](https://github.com/donald-42/ACCsharedmemory)
