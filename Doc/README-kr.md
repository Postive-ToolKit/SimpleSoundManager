# SimpleSoundManager
SimpleSoundManager은 유니티에서 손쉽게 사운드 에셋을 관리하고 사용하기 위해 만들어진 패키지입니다. SoundDB을 이용해 새로운 사운드를 추가하거나, 볼륨, 피치, 3D 사운드 여부 등을 설정할 수 있습니다.
해당 패키지는 [CategoryzedDB](https://github.com/Postive-ToolKit/CategorizedDB) 패키지를 기반으로 제작되었으며 [CategoryzedDB](https://github.com/Postive-ToolKit/CategorizedDB) 패키지를 먼저 설치해야 합니다.
## 목차
- [SimpleSoundManager](#simplesoundmanager)
  - [목차](#목차)
  - [Features](#features)
  - [Getting Started](#getting-started)
    - [SoundDB 생성](#sounddb-생성)
    - [SoundDB 에디터](#sounddb-에디터)
    - [SoundData 추가](#sounddata-추가)
    - [SoundData 값 변경](#sounddata-값-변경)
      - [2D 사운드롸 3D 사운드](#2d-사운드롸-3d-사운드)
      - [3D 사운드 설정](#3d-사운드-설정)
    - [SoundData 삭제](#sounddata-삭제)
    - [Sound 선택](#sound-선택)
    - [Sound 재생](#sound-재생)
  - [설치 방법](#설치-방법)
    - [Git URL](#git-url)
  - [마무리](#마무리)
## Features
- 사운드 관리
- 사운드 추가 및 수치 조정
- 사운드 카테고리 변경
## Getting Started
[유니티 패키지 매니저](#git-url)를 이용해 설치하는 방법을 설명합니다.

### SoundDB 생성
![image](https://github.com/user-attachments/assets/f792856b-9d35-4925-a8fa-155a4cab6cf2)

먼저 사운드를 사용하기 위한 데이터베이스를 생성해야합니다. `Assets > Create > Data > SoundDB`를 선택하여 SoundDB를 생성합니다.
### SoundDB 에디터
![image](https://github.com/user-attachments/assets/e4b94d4b-99ff-4448-9a2a-2ca358d28c2a)

SoundDB 에디터는 SimpleSoundManager의 데이터베이스를 관리하는 에디터입니다. SoundDB 에디터를 통해 사운드를 추가하거나 수정할 수 있습니다.

좌측에 TreeView를 통해 카테고리나 사운드 등을 선택할 수 있으며 우클릭을 통해 메뉴를 열어 사운드를 추가하거나 삭제하는 것이 가능합니다.

우측에 인스펙터에서 사운드가 속한 카테고리 혹은 사운드 데이터 및 설정 등을 변경할 수 있습니다.

### SoundData 추가
![image](https://github.com/user-attachments/assets/2d63fda4-58b2-4193-9b30-8c1465a6c9a9)

좌측 TreeView에서 우클릭을 통해 메뉴를 여는 것이 가능합니다. 메뉴 상단에는 현재 선택되어 있는 카테고리가 표시됩니다. 아무 카테고리도 선택되어 있지 않을 경우 Root 카테고리에 사운드를 추가하게 됩니다.

만일 특정 카테고리를 선택한 이후 Root 카테고리로 돌아가고 싶다면 TreeView에 더블클릭을 하면 됩니다.

### SoundData 값 변경
![image](https://github.com/user-attachments/assets/52e2ac77-6992-4a80-ad1c-c6e03c363ec4)

사운드 설정 상단에는 해당 사운드 데이터의 카테고리와 이름 등을 설정할 수 있는 공간이 있습니다. 해당 설정을 변경하는 것을 통해 에디터 상에 표시될 사운드의 경로를 정할 수 있습니다.

그 아래 `Sound Settings` 섹션에는 사운드의 볼륨, 피치, 2D 사운드 여부, 3D 사운드 여부 등을 설정할 수 있습니다.

설정 값들은 다음과 같습니다.
- `Mixer` : 해당 사운드의 볼륨을 조절할 믹서를 선택합니다.
- `Clips` : 해당 사운드의 클립을 선택합니다. 만일 1개 이상의 클립을 선택할 경우 랜덤으로 재생됩니다.
- `Spatial Blend` : 3D 사운드일 경우 3D 사운드의 정도를 조절합니다. 만약 0이면 2D 사운드, 1이면 3D 사운드가 됩니다. 값이 0 이상일 경우 3D 사운드 옵션이 활성화됩니다.
- `Use Random Volume` : 볼륨을 랜덤으로 설정할지 여부를 결정합니다.
  - `Volume` : 사운드의 볼륨을 설정합니다. 만약 `Use Random Volume`가 활성화되어 있다면 최소값과 최대값을 설정할 수 있습니다.
- `Use Random Pitch` : 피치를 랜덤으로 설정할지 여부를 결정합니다.
  - `Pitch` : 사운드의 피치를 설정합니다. 만약 `Use Random Pitch`가 활성화되어 있다면 최소값과 최대값을 설정할 수 있습니다.

#### 2D 사운드롸 3D 사운드
2D 사운드는 3D 사운드와 달리 사운드의 위치에 따라 볼륨이 변하지 않습니다. 3D 사운드는 사운드의 위치에 따라 볼륨이 변하며, `Spatial Blend` 값을 조절하여 2D 사운드와 3D 사운드의 비율을 조절할 수 있습니다.

만약 3D 사운드를 사용할 경우 `Spatial Blend` 값을 0 이상으로 설정하고, `Min Distance`와 `Max Distance`를 설정해야합니다. `Min Distance`는 사운드의 최소 거리, `Max Distance`는 사운드의 최대 거리를 나타냅니다. `Min Distance` 이상에서 `Max Distance` 이하의 거리에서 사운드가 재생됩니다.

#### 3D 사운드 설정
![image](https://github.com/user-attachments/assets/c22cef17-b1ad-421d-ac89-0d2014913300)

3D 사운드의 경우 아래와 같은 설정들이 활성화 되어 표시됩니다.
- `Min Distance` : 사운드의 최소 거리를 설정합니다.
- `Max Distance` : 사운드의 최대 거리를 설정합니다.

**그래프 프로퍼티**
- `Doppler Level` : 도플러 효과의 정도를 설정합니다.
- `Volume Rolloff` : 사운드의 볼륨이 변화하는 정도를 설정합니다.
- `Spatial Blend` : 3D 사운드의 정도를 설정합니다.
- `Reverb Zone Mix` : 리버브 존의 정도를 설정합니다.
### SoundData 삭제
![image](https://github.com/user-attachments/assets/0a52bcac-ab4d-4cf5-8d23-0b64d42eff43)

### Sound 선택
![image](https://github.com/user-attachments/assets/e7480efa-722e-4a56-9184-027df7a63b19)

삭제하고 싶은 사운드를 선택한 후 우클릭을 통해 `Delete`를 선택하면 해당 사운드가 삭제됩니다.

### Sound 재생
사운드 재생은 `SoundManager`를 통해 이루어집니다. `SoundManager`는 사운드를 재생하고 관리하는 클래스입니다. `SoundManager`를 통해 사운드를 재생하려면 다음과 같이 코드를 작성하면 됩니다.

```csharp
using Postive.SimpleSoundAssetManager.Runtime;
using Postive.SimpleSoundAssetManager.Runtime.Attributes;
using UnityEngine;
public class TestComponent : MonoBehaviour
{
    // The SoundSelector attribute is used to select a sound from the SoundDB database
    [SoundSelector] [SerializeField] private string _sound;
    // Start is called before the first frame update
    private void PlaySound() {
        // Play the sound by using the SoundManager
        SoundManager.PlaySound(_sound,transform.position);
    }
}
```
`SoundSelector` 어트리뷰트를 사용하여 사운드를 선택할 수 있습니다. `SoundManager.PlaySound`를 통해 사운드를 재생할 수 있습니다.

`SoundSelector`을 통해 사운드를 선택하면 GUID 정보를 가지고 데이터를 저장하기 때문에 사운드의 이름이 변경되거나 경로가 변경되어도 문제없이 사용할 수 있습니다.

`SoundManager.PlaySound` 함수에 SoundData의 GUID를 인자로 넘겨주면 해당 사운드가 재생됩니다.

`SoundManager.PlaySound` 함수의 경우 Vector3 혹은 Transform을 인자로 받을 수 있습니다. 만약 Vector3를 인자로 받을 경우 해당 위치에서 사운드가 재생되며, Transform을 인자로 받을 경우 해당 Transform의 위치에서 사운드가 재생됩니다.

## 설치 방법
패키지를 설치하기 전에 [CategoryzedDB](https://github.com/Postive-ToolKit/CategorizedDB) 패키지를 먼저 설치해야 합니다.
### Git URL
유니티 2019.3.4f1 이전 버전에서틑 테스트 되지 않았습니다. 때문에 되도록이면 그 이상의 버전을 사용해주세요. 유니티 패키지 매니저에서 `https://github.com/Postive-ToolKit/SimpleSoundManager.git` URL을 이용하여 설치가 가능합니다.

![image](https://github.com/user-attachments/assets/c1a97d72-5be2-429f-89ac-0198418abf2d)

![image](https://github.com/user-attachments/assets/186f3c73-23e9-4c41-96c6-5256b43a234a)

## 마무리
위와 같은 방법으로 SimpleSoundManager을 설치하고 사용할 수 있습니다. SimpleSoundManager을 이용해 유니티에서 손쉽게 사운드를 관리하고 사용해보세요.
