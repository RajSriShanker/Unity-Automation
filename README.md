# Unity Automation
Automation test cases for [Endless Runner - Sample Game](https://assetstore.unity.com/packages/templates/tutorials/endless-runner-sample-game-87901) using the [AltTester](https://github.com/alttester/AltTester-Unity-SDK) tool within the Unity Engine written in C#.

## Test Case: Menu UI Selection
- Interact with every UI button within the main menu, and verify all menu buttons can be closed.
  - Verify all UI in Leaderboards are correct, then close the menu
  - Verify all UI in Store are correct, then close the menu
  - Verify all UI in Missions are correct, then close the menu
  - Verify all UI in Settings are correct, then close the menu


| Manual Test  | Automation Test |
| ------------- | ------------- |
| ![AutomationTestGif_2](https://github.com/RajSriShanker/Unity-Automation/assets/7788792/c7c5588e-ee36-4796-8d70-029bfe38c855)  | ![AutomationTestGif](https://github.com/RajSriShanker/Unity-Automation/assets/7788792/d32ab72f-3b0c-499f-886d-29ee2b5e73f7)  |
| 2-4 minutes | 1.4 seconds |


## Test Case: Player Input & UI
- Progress through a level and verify all UI is showing the intended content, including the ability to start over.
  - Verify all player inputs are able to be entered
  - Verify UI in the level is correct
  - Verify the player is able to lose hearts
  - Verify all information on death screen
  - Verify is able to start level after losing

| Manual Test  | Automation Test |
| ------------- | ------------- |
| ![AutomationTestGif_5](https://github.com/RajSriShanker/Unity-Automation/assets/7788792/b9ea76aa-ecaf-4fb6-ba63-ca453f5435e7) | ![AutomationTestGif_4](https://github.com/RajSriShanker/Unity-Automation/assets/7788792/5c238f3e-1a8d-4769-97ee-5ddea65a6bcb) |
| 8-10 minutes | 18 seconds |
