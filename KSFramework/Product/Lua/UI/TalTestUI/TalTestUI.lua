local TalTestUI = {}
extends(TalTestUI,UIBase)

function TalTestUI:OnInit(controller)
    print("================================ TalTestUI:OnInit ============================")
    self.Controller = controller
    if not self.Image then
        self.Image = self:GetUIImage('Image')
    end
    if not self.Text then
        self.Text = self:GetUIText('Image/Text')
    end
    if not self.Button then
        self.Button = self:GetUIButton('Button')
    end
    Tools.SetButton(self.Button, function()
        UIModule.Instance:CloseWindow("TalTestUI")
    end)
end

function TalTestUI:OnOpen()
    print("================================ TalTestUI:OnOpen ============================")
    local rand
    rand = math.random(1, 3)
    local finalText = 'this is a demo'..rand
    print(tostring(self.Text)..'___+_+_+')
    self.Text.text = finalText
    if rand == 3 then
--         print(self.Image.color)
        self.Image.color = Color(1,0,0,1)
    end
end

function TalTestUI:OnClose()
    print("================================ TalTestUI:OnClose ============================")
end
return TalTestUI