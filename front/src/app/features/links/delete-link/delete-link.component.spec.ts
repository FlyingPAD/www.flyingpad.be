import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteLinkComponent } from './delete-link.component';

describe('DeleteLinkComponent', () => {
  let component: DeleteLinkComponent;
  let fixture: ComponentFixture<DeleteLinkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeleteLinkComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteLinkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
