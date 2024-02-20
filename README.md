## Make unity windows games runs smoother on Android

### to make games run smooth on android
* the prefab number of polygons should be small
* we don't need to use postprocessing since this could exhaust the GPU or just lower the postprocess settings
* because Android does not use DirectX but OpenGL and Vulkan so the Colorspace should be Gamma
