---@type LoadingPage
local LoadingPage = {}
extends(LoadingPage, UIBase)

function UIBillboard:OnInit(controller)
    self.Controller = controller
    if not self.Image then
        self.Image = self:GetUIImage("Image")
    end
end

function UIBillboard:OnOpen()

end

function UIBillboard:OnClose()
--     self
end

return LoadingPage
