---
ページタイプ: サンプル
言語:
 C#
製品:
 office-teams
解説: インシデントを検索・報告し、専門家とすぐに連絡を取るためのMicrosoft Teamsボットとメッセージング拡張機能
---

# インシデントレポーターアプリテンプレート

| [ドキュメンテーション](https://github.com/officeDevJp/microsoft-teams-apps-incidentreport/wiki/Home) | [管理者ガイド](https://github.com/officeDevJp/microsoft-teams-apps-incidentreport/wiki/%E7%AE%A1%E7%90%86%E8%80%85%E3%82%AC%E3%82%A4%E3%83%89) |
| ---- | ---- |

## はじめに

組織内でのインシデント報告やその管理は手動処理で実施されることが多く、効率を向上させる余地があります。報告者は電子メールやアドホックチャネルのようなチャットベースのメッセージを使用して新しいインシデントを関係者に報告することができますが、電子メールやチャットベースのメッセージングシステムは一時的または単発的な性質を持ち、根本原因分析や事後分析をするために報告された情報を簡単に調査することができません。

Microsoft Teamsのインシデントレポーターボットを使用することで、インシデントへの応答、報告、および記録を簡単かつ迅速に実施することができます。つまり、インシデントへの迅速な対応を可能にします。ボットの主な機能は以下の通りです。
- 各インシデントの時間、日付、および場所の自動収集
- ご使用になる職場のニーズに応じてカスタマイズ可能なインシデント報告フォーム
- スペシャリストチーム内でのインシデント報告により、迅速な協力と関係者への通知が可能となり完了まで追跡可能

![New Request in Incident Reporter personal chat](https://user-images.githubusercontent.com/70117421/91243749-a69a0600-e785-11ea-9740-24978c939cce.png)

![Messaging extension for experts](https://user-images.githubusercontent.com/70117421/91153256-f2ec3400-e6fa-11ea-948f-f723f908050c.png)

## 法的通知
このアプリテンプレートは、[MITライセンス条項](https://github.com/officeDevJp/microsoft-teams-apps-incidentreport/blob/main/LICENSE) に従って提供されます。これらの条件に加え、このアプリテンプレートを使用することで以下に同意するものとします。

-	アプリによる個人データの使用、収集、および取り扱いに関する全ての適用可能なプライバシーおよびセキュリティ規制を遵守する責任があります。これには、アプリが組織内でサイドローディングされるように開発されている場合、組織の全ての内部プライバシーおよびセキュリティポリシーへの準拠が含まれます。

-	該当する場合、アプリを通して収集されたデータに関するデータ関連のインシデントまたはデータ主体の要求に対して責任を負う場合があります。


-	米国およびその他の国におけるMicrosoftの商標または登録商標、およびこのリポジトリーに含まれるロゴはMicrosoftの資産であり、このプロジェクトに対するライセンスでは、Microsoftの名前、ロゴ、または商標を使用する権利は付与されません。Microsoftの一般的なガイドラインは[こちら](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general.aspx)から確認できます。

-	このテンプレートを使用しても、Teamsアプリストアへの承認は保証されません。このアプリをTeamsアプリストアで利用できるようにするには、[送信と検証のプロセス](https://docs.microsoft.com/en-us/microsoftteams/platform/concepts/deploy-and-publish/appsource/publish)、および独自のプライバシーに関する声明やアプリの利用規約など、関連する全ての要件に準拠する必要があります。

## 展開方法

[管理者ガイド](https://github.com/officeDevJp/microsoft-teams-apps-incidentreport/wiki/%E7%AE%A1%E7%90%86%E8%80%85%E3%82%AC%E3%82%A4%E3%83%89)の手順に従ってください。

## コントリビューション

このプロジェクトは、コントリビュートと提案を歓迎します。コントリビュートでは、寄稿者はコントリビュートを使用する権利を付与する権利があることを宣言する貢献者ライセンス同意書（CLA）に同意する必要があります。詳細については https://cla.opensource.microsoft.com を参照してください。

プル要求を送信すると、CLAを提供する必要があるか、また、PR（ステータスチェック、コメントなど）が適切に付与されているかをCLAボットが自動的に判断します。ボットの指示に従ってください。これは、CLAを使用して全てのリポジトリーを通して1回だけ行う必要があります。

このプロジェクトは、[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/)を採用しています。詳細については、[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)を参照するか、追加の質問やコメントを添えて[opencode@microsoft.com](mailto:opencode@microsoft.com)に問い合わせてください。
