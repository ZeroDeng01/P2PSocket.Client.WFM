# P2PSocket.Client.WFM

基于Wireboy.Socket.P2PSocket的内网穿透客户端软件

## 关于Wireboy.Socket.P2PSocket

感谢Wireboy的[Wireboy.Socket.P2PSocket](https://github.com/bobowire/Wireboy.Socket.P2PSocket)内核支持

了解Wireboy.Socket.P2PSocket详情[点击这里](https://github.com/bobowire/Wireboy.Socket.P2PSocket)

## 客户端的使用说明

如果您是专业用户，高级配置信息详细请[点此查看](https://github.com/bobowire/Wireboy.Socket.P2PSocket/wiki)

### 基础配置

#### 服务器地址

服务器地址填写您的P2P.Socket服务端的地址

*免费测试地址www.p2psocket.com:3387（转发模式限速50kb/s）*

#### 客户端名称

客户端名称默认为生成的随机八位数字，您也可以修改为您喜欢的名称（不能包含中文字符和特殊符号）例如`TEST`，客户端名称不能和其他在线连接的设备重复。

### 内网穿透连接

#### 把自己的指定端口暴漏给公网[作为被控端A设备]

您想把自己计算机（假设客户端名称注册为`TEST`）上面的指定端口暴露给公网的话只需要在`本机开放端口列表`中添加您向外网访问的端口号即可，例如`3389`端口

#### 连接其他设备的远程端口[作为控制端B设备]

您如果想在作为控制端的B设备连接作为被控端的A设备的`3389`端口您只需要打开P2PSocket.Client.WFM主程序：

1. 在`客户端连接信息`中填写您的`本地端口`例如`13389`
2. 在`客户端连接信息`中填写`对方客户端名称`例如`TEST`
3. 在`客户端连接信息`中填写`对方开启端口号`例如`3389`
4. 如果您需要通过P2P连接（暂时还不是100%可以穿透成功）请选中`使用P2P通信`
5. 然后您在B设备访问IP`127.0.0.1`端口`13389`即可访问注册名称为`TEST`的计算机的`3389`端口了



## 更新日志

- 客户端基础功能支持
  - 端口开放
  - 远程客户端的连接